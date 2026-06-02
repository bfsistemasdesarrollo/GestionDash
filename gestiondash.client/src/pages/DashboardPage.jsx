import { useAuth } from '../context/AuthContext';
import { Button } from '@/components/ui/button';
import { LogOut, LayoutDashboard, BarChart2, Users, Package, Settings } from 'lucide-react';

const navItems = [
    { icon: LayoutDashboard, label: 'Dashboard', active: true },
    { icon: BarChart2, label: 'Reportes' },
    { icon: Users, label: 'Clientes' },
    { icon: Package, label: 'Artículos' },
    { icon: Settings, label: 'Configuración' },
];

const statCards = [
    { label: 'Ventas del día',      value: '—', emoji: '📈' },
    { label: 'Clientes activos',    value: '—', emoji: '👥' },
    { label: 'Artículos en stock',  value: '—', emoji: '📦' },
    { label: 'Movimientos hoy',     value: '—', emoji: '🔄' },
];

export default function DashboardPage() {
    const { user, logout } = useAuth();

    const initials = user?.usuNom?.[0]?.toUpperCase() ?? '?';

    return (
        <div className="flex-1 flex flex-col min-h-0">
            {/* Navbar superior */}
            <header className="h-14 shrink-0 border-b border-gray-200 bg-white flex items-center px-5 gap-3">
                {/* Marca */}
                <div className="flex items-center gap-2.5 mr-4">
                    <div className="w-8 h-8 rounded-lg flex items-center justify-center">
                        <img src="/dashboard-icon.png" alt="" className="w-8 h-8" />
                    </div>
                    <span className="font-bold text-gray-900 text-sm tracking-tight">Gestión Dashboard</span>
                </div>

                {/* Nav */}
                <nav className="hidden md:flex items-center gap-0.5 flex-1">
                    {navItems.map(({ icon: Icon, label, active }) => (
                        <button
                            key={label}
                            className={`flex items-center gap-1.5 px-3 py-1.5 rounded-md text-sm transition-colors ${
                                active
                                    ? 'bg-purple-50 text-purple-700 font-medium'
                                    : 'text-gray-500 hover:text-gray-900 hover:bg-gray-100'
                            }`}
                        >
                            <Icon size={14} />
                            {label}
                        </button>
                    ))}
                </nav>

                {/* Usuario + logout */}
                <div className="ml-auto flex items-center gap-3">
                    <div className="hidden sm:flex flex-col items-end leading-tight">
                        <span className="text-sm font-medium text-gray-900">{user?.usuNomLar}</span>
                        <span className="text-xs text-gray-400">{user?.usuMail}</span>
                    </div>
                    <div
                        className="w-8 h-8 rounded-full flex items-center justify-center text-white text-xs font-bold shadow-sm"
                        style={{ background: 'linear-gradient(135deg, #aa3bff, #7b1ed6)' }}
                    >
                        {initials}
                    </div>
                    <Button
                        variant="ghost"
                        size="sm"
                        onClick={logout}
                        className="text-gray-400 hover:text-gray-700 gap-1.5"
                    >
                        <LogOut size={15} />
                        <span className="hidden sm:inline">Salir</span>
                    </Button>
                </div>
            </header>

            {/* Contenido principal */}
            <main className="flex-1 bg-gray-50 p-6 overflow-auto">
                {/* Tarjetas de métricas */}
                <div className="grid grid-cols-1 sm:grid-cols-2 lg:grid-cols-4 gap-4">
                    {statCards.map(({ label, value, emoji, color }) => (
                        <div
                            key={label}
                            className="bg-white rounded-xl p-5 border border-gray-100 shadow-sm hover:shadow-md transition-shadow"
                        >
                            <div className="flex items-center justify-between mb-3">
                                <span className="text-xs font-semibold text-gray-400 uppercase tracking-wider">
                                    {label}
                                </span>
                                <div
                                    className="w-8 h-8 rounded-lg flex items-center justify-center text-base"
                                    style={{ background: `${color}18` }}
                                >
                                    {emoji}
                                </div>
                            </div>
                            <div className="text-2xl font-bold text-gray-800">{value}</div>
                            <div className="text-xs text-gray-400 mt-1">Sin datos aún</div>
                        </div>
                    ))}
                </div>
            </main>
        </div>
    );
}
