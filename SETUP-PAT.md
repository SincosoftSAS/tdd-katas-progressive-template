# 🔧 Configuración de Personal Access Token

## ❌ Problema Identificado
El `github-actions[bot]` token tiene limitaciones y no puede crear PRs en repositories de estudiantes.

**Error detectado:**
```
Resource not accessible by integration (HTTP 403)
```

## ✅ Solución: Personal Access Token (PAT)

### 📋 Pasos para configurar PAT:

#### 1. Crear Personal Access Token
1. Ve a **GitHub.com** → **Settings** → **Developer settings** → **Personal access tokens** → **Tokens (classic)**
2. Click **"Generate new token (classic)"**
3. **Nombre:** `TDD Katas Sync Token`
4. **Expiration:** `90 days` (o según prefieras)
5. **Scopes requeridos:**
   - ✅ `repo` (Full control of private repositories)
   - ✅ `workflow` (Update GitHub Action workflows)
   - ✅ `write:org` (Write org and team membership, write org projects)

#### 2. Agregar como Secret
1. Ve al repo **tdd-katas-progressive-template**
2. **Settings** → **Secrets and variables** → **Actions**
3. Click **"New repository secret"**
4. **Name:** `PAT_TOKEN`
5. **Secret:** Pega el token generado
6. Click **"Add secret"**

### 🚀 Después de configurar:

1. **Ejecuta Dry Run:** `🔄 Sync to Students (PAT)` con `dry_run=true`
2. **Verifica que detecte** los repos y confirme PAT configurado
3. **Ejecuta Real:** Cambia `dry_run=false` para crear los PRs

### 🔍 Verificación
El workflow te dirá:
- ✅ `PAT_TOKEN configurado - listo para crear PRs`
- ❌ `PAT_TOKEN no configurado - no podrá crear PRs`

---

## 🛡️ Seguridad del Token

- **Alcance:** Solo repos de SincosoftSAS
- **Uso:** Solo para crear PRs de sincronización
- **Renovación:** Configura recordatorio antes del vencimiento
- **Rotación:** Cambia el token periódicamente

---

## 🔄 Workflows Disponibles

1. **🔍 Debug Permissions** - Diagnóstico (ya ejecutado)
2. **🔄 Sync to Students (PAT)** - Solución recomendada ⭐
3. **🔄 Sync to Students (Fixed)** - Solución original (limitada)