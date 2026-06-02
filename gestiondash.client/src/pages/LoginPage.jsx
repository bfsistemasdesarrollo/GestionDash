import { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { useAuth } from '../context/AuthContext';
import { Button } from '@/components/ui/button';
import { Input } from '@/components/ui/input';
import { Label } from '@/components/ui/label';
import { Card, CardContent, CardDescription, CardHeader, CardTitle } from '@/components/ui/card';

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
        <div className="flex-1 flex min-h-0">
            {/* Panel izquierdo — marca */}
            <div
                className="hidden lg:flex w-[46%] shrink-0 flex-col items-center justify-center p-16 relative overflow-hidden select-none"
                style={{ background: 'linear-gradient(145deg, #aa3bff 0%, #7b1ed6 55%, #4e0e9a 100%)' }}
            >
                {/* Círculos decorativos */}
                <div
                    className="absolute -top-20 -right-20 w-80 h-80 rounded-full opacity-20"
                    style={{ background: 'radial-gradient(circle, #fff 0%, transparent 70%)' }}
                />
                <div
                    className="absolute -bottom-16 -left-16 w-72 h-72 rounded-full opacity-15"
                    style={{ background: 'radial-gradient(circle, #fff 0%, transparent 70%)' }}
                />

                <div className="relative z-10 flex flex-col items-center text-center">
                    {/* Ícono */}
                    <div className="w-28 h-28 mb-8 rounded-3xl flex items-center justify-center shadow-2xl"
                        style={{ background: 'rgba(255,255,255,0.15)', backdropFilter: 'blur(8px)', border: '1px solid rgba(255,255,255,0.25)' }}>
                        <img src="/dashboard-icon.png" alt="GestionDash" className="w-20 h-20 drop-shadow-md" />
                    </div>

                    <div className="text-white text-4xl font-bold tracking-tight mb-3">
                        GestionDash
                    </div>
                    <div className="text-purple-200 text-base leading-relaxed max-w-xs">
                        Sistema de gestión empresarial integrado
                    </div>

                    {/* Módulos */}
                    <div className="mt-12 grid grid-cols-3 gap-3 w-full max-w-xs">
                        {[
                            { label: 'Ventas', emoji: '📊' },
                            { label: 'Clientes', emoji: '👥' },
                            { label: 'Artículos', emoji: '📦' },
                        ].map(({ label, emoji }) => (
                            <div
                                key={label}
                                className="rounded-xl p-3 text-center"
                                style={{ background: 'rgba(255,255,255,0.1)', border: '1px solid rgba(255,255,255,0.2)' }}
                            >
                                <span className="text-xl">{emoji}</span>
                                <div className="text-white/80 text-xs mt-1">{label}</div>
                            </div>
                        ))}
                    </div>
                </div>
            </div>

            {/* Panel derecho — formulario */}
            <div className="flex-1 flex items-center justify-center p-6 bg-gray-50">
                <div className="w-full max-w-sm">
                    {/* Logo mobile */}
                    <div className="lg:hidden flex flex-col items-center mb-8">
                        <div
                            className="w-16 h-16 rounded-2xl flex items-center justify-center mb-3 shadow-lg"
                            style={{ background: 'linear-gradient(145deg, #aa3bff, #7b1ed6)' }}
                        >
                            <img src="/dashboard-icon.png" alt="" className="w-10 h-10" />
                        </div>
                        <span className="text-xl font-bold text-gray-900">GestionDash</span>
                    </div>

                    <Card className="shadow-xl border-0 bg-white">
                        <CardHeader className="pb-4">
                            <CardTitle className="text-2xl font-bold text-gray-900">Bienvenido</CardTitle>
                            <CardDescription>
                                Ingrese sus credenciales para continuar
                            </CardDescription>
                        </CardHeader>
                        <CardContent>
                            <form onSubmit={handleSubmit} className="space-y-4">
                                <div className="space-y-1.5">
                                    <Label htmlFor="usuMail" className="text-gray-700">
                                        Correo electrónico
                                    </Label>
                                    <Input
                                        id="usuMail"
                                        name="usuMail"
                                        type="email"
                                        autoComplete="email"
                                        required
                                        value={form.usuMail}
                                        onChange={handleChange}
                                        placeholder="usuario@empresa.com"
                                        className="h-11"
                                    />
                                </div>

                                <div className="space-y-1.5">
                                    <Label htmlFor="usuCla" className="text-gray-700">
                                        Contraseña
                                    </Label>
                                    <Input
                                        id="usuCla"
                                        name="usuCla"
                                        type="password"
                                        autoComplete="current-password"
                                        required
                                        value={form.usuCla}
                                        onChange={handleChange}
                                        placeholder="••••••••"
                                        className="h-11"
                                    />
                                </div>

                                {error && (
                                    <div className="rounded-lg bg-red-50 border border-red-200 px-3 py-2.5">
                                        <p className="text-sm text-red-600 m-0">{error}</p>
                                    </div>
                                )}

                                <Button
                                    type="submit"
                                    className="w-full h-11 text-white font-semibold mt-1 border-0"
                                    disabled={loading}
                                    style={{
                                        background: loading
                                            ? '#c084fc'
                                            : 'linear-gradient(135deg, #aa3bff 0%, #7b1ed6 100%)',
                                    }}
                                >
                                    {loading ? 'Ingresando...' : 'Ingresar'}
                                </Button>
                            </form>
                        </CardContent>
                    </Card>

                    <p className="text-center text-xs text-gray-400 mt-5">
                        BF Sistemas &copy; {new Date().getFullYear()}
                    </p>
                </div>
            </div>
        </div>
    );
}
