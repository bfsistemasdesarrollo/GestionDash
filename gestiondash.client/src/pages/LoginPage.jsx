import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../context/AuthContext';
import './LoginPage.css';

export default function LoginPage() {
    const { login } = useAuth();
    const navigate = useNavigate();
    const [form, setForm] = useState({ usuMail: '', usuCla: '' });
    const [error, setError] = useState('');
    const [loading, setLoading] = useState(false);

    const handleChange = (e) => {
        setForm(prev => ({ ...prev, [e.target.name]: e.target.value }));
        if (error) setError('');
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        setLoading(true);
        setError('');

        try {
            const res = await fetch('/api/auth/login', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(form),
            });

            const data = await res.json();

            if (!res.ok) {
                setError(data.message || 'Error al iniciar sesión.');
                return;
            }

            login(data.token, {
                usuCod: data.usuCod,
                usuNom: data.usuNom,
                usuNomLar: data.usuNomLar,
                usuMail: data.usuMail,
                sgruCod: data.sgruCod,
            });
            navigate('/', { replace: true });
        } catch {
            setError('No se pudo conectar con el servidor.');
        } finally {
            setLoading(false);
        }
    };

    return (
        <div className="login-container">
            <div className="login-card">
                <p className="login-logo">GestionDash</p>
                <p className="login-subtitle">Inicie sesión para continuar</p>

                <form onSubmit={handleSubmit} className="login-form">
                    <div className="form-group">
                        <label htmlFor="usuMail">Correo electrónico</label>
                        <input
                            id="usuMail"
                            name="usuMail"
                            type="email"
                            autoComplete="email"
                            required
                            value={form.usuMail}
                            onChange={handleChange}
                            placeholder="usuario@empresa.com"
                        />
                    </div>

                    <div className="form-group">
                        <label htmlFor="usuCla">Contraseña</label>
                        <input
                            id="usuCla"
                            name="usuCla"
                            type="password"
                            autoComplete="current-password"
                            required
                            value={form.usuCla}
                            onChange={handleChange}
                            placeholder="••••••••"
                        />
                    </div>

                    {error && <p className="login-error">{error}</p>}

                    <button type="submit" className="login-btn" disabled={loading}>
                        {loading ? 'Ingresando...' : 'Ingresar'}
                    </button>
                </form>
            </div>
        </div>
    );
}
