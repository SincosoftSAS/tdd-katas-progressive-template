#!/bin/bash
# Script para instalar hooks de Git localmente
# Usage: ./install-hooks.sh

echo "🔧 TDD Katas - Instalación de Git Hooks"
echo "======================================"

# Check if we're in a git repository
if [ ! -d ".git" ]; then
    echo "❌ Error: No estás en un repositorio Git"
    echo "   Ejecuta este script desde la raíz del proyecto"
    exit 1
fi

# Create hooks directory if it doesn't exist
if [ ! -d ".git/hooks" ]; then
    mkdir -p .git/hooks
fi

# Copy pre-commit hook
if [ -f ".github/hooks/pre-commit" ]; then
    echo "📋 Copiando pre-commit hook..."
    cp .github/hooks/pre-commit .git/hooks/pre-commit
    chmod +x .git/hooks/pre-commit
    echo "✅ Pre-commit hook instalado"
else
    echo "❌ Error: No se encontró .github/hooks/pre-commit"
    exit 1
fi

echo ""
echo "🎉 ¡Hooks instalados correctamente!"
echo ""
echo "📖 ¿Qué hace el pre-commit hook?"
echo "   - Ejecuta tests visibles antes de cada commit"
echo "   - Te avisa si hay tests fallidos"
echo "   - Te da feedback inmediato ANTES de push"
echo ""
echo "🚀 ¿Qué sucede después del push?"
echo "   - GitHub Actions ejecuta tests completos (incluyendo ocultos)"
echo "   - Recibes feedback via commit status y comentarios"
echo "   - Si pasas todos los tests, se desbloquea el siguiente kata"
echo ""
echo "💡 Comandos útiles:"
echo "   git commit          → Ejecuta tests automáticamente"
echo "   git commit --no-verify → Saltar tests (no recomendado)"
echo "   dotnet test         → Ejecutar tests manualmente"
echo ""