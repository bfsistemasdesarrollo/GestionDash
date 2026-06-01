import { useAuth } from '../context/AuthContext';
import './DashboardPage.css';

export default function DashboardPage() {
    const { user, logout } = useAuth();

    return (
        <div className="dashboard">
            <header className="dashboard-header">
                <span className="dashboard-brand">GestionDash</span>
                <div className="dashboard-user">
                    <span className="dashboard-username">{user?.usuNomLar}</span>
                    <button onClick={logout} className="logout-btn">Cerrar sesión</button>
                </div>
            </header>
            <main className="dashboard-content">
                <h2>Bienvenido, {user?.usuNom}</h2>
            </main>
        </div>
    );
}
