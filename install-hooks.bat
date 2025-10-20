@echo off
REM Script para instalar hooks de Git localmente (Windows)
REM Usage: install-hooks.bat

echo 🔧 TDD Katas - Instalación de Git Hooks
echo ======================================

REM Check if we're in a git repository
if not exist ".git" (
    echo ❌ Error: No estás en un repositorio Git
    echo    Ejecuta este script desde la raíz del proyecto
    pause
    exit /b 1
)

REM Create hooks directory if it doesn't exist
if not exist ".git\hooks" (
    mkdir .git\hooks
)

REM Copy pre-commit hook
if exist ".github\hooks\pre-commit" (
    echo 📋 Copiando pre-commit hook...
    copy .github\hooks\pre-commit .git\hooks\pre-commit
    echo ✅ Pre-commit hook instalado
) else (
    echo ❌ Error: No se encontró .github\hooks\pre-commit
    pause
    exit /b 1
)

echo.
echo 🎉 ¡Hooks instalados correctamente!
echo.
echo 📖 ¿Qué hace el pre-commit hook?
echo    - Ejecuta tests visibles antes de cada commit
echo    - Te avisa si hay tests fallidos
echo    - Te da feedback inmediato ANTES de push
echo.
echo 🚀 ¿Qué sucede después del push?
echo    - GitHub Actions ejecuta tests completos (incluyendo ocultos)
echo    - Recibes feedback via commit status y comentarios
echo    - Si pasas todos los tests, se desbloquea el siguiente kata
echo.
echo 💡 Comandos útiles:
echo    git commit          → Ejecuta tests automáticamente
echo    git commit --no-verify → Saltar tests (no recomendado)
echo    dotnet test         → Ejecutar tests manualmente
echo.
pause