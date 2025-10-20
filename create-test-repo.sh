#!/bin/bash

# Script para crear un repo de prueba y probar el workflow

echo "🧪 Creando repositorio de prueba para validar sincronización..."

REPO_NAME="tdd-katas-test-student"
ORG="SincosoftSAS"

echo "📁 Creando repo: $REPO_NAME"

# Crear repo de prueba
curl -X POST \
  -H "Accept: application/vnd.github.v3+json" \
  -H "Authorization: token $GITHUB_TOKEN" \
  "https://api.github.com/orgs/$ORG/repos" \
  -d "{
    \"name\": \"$REPO_NAME\",
    \"description\": \"Repo de prueba para validar sincronización de template\",
    \"private\": false,
    \"auto_init\": true
  }"

echo ""
echo "✅ Repo de prueba creado!"
echo "🔄 Ahora puedes ejecutar el workflow y debería encontrar 1 repositorio"
echo "📋 Repo creado: https://github.com/$ORG/$REPO_NAME"
echo ""
echo "🗑️  Para limpiar después: ve al repo y elimínalo manualmente"