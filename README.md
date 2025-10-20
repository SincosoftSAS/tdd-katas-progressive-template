# 🎯 TDD Journey - Progressive Katas

Welcome to your personal TDD learning journey!

## 📖 What is This?

Complete coding katas one at a time, unlocking new ones as you progress.

## 📊 Your Progress

**👉 Check your detailed progress dashboard: [`PROGRESS.md`](PROGRESS.md)**

### 🔓 Current Kata

**Kata 01: FizzBuzz** - You're here! 🎯

### 🔒 Locked Katas

_Complete current kata to unlock the next one..._

### ✅ Completed Katas

_No katas completed yet. Start with Kata 01!_

---

## 🚀 Getting Started

```bash
# Clone this repository
git clone YOUR_REPO_URL
cd YOUR_REPO

# Install feedback hooks (RECOMMENDED)
./install-hooks.sh         # Linux/Mac
# OR
install-hooks.bat          # Windows

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run tests (they should fail initially - that's expected!)
dotnet test
```

---

## � **¿Cómo recibo feedback?**

Tenemos **múltiples canales** para darte feedback inmediato:

### ⚡ **Feedback Pre-commit** (Instala hooks)
- 🔍 Tests automáticos **antes** de commit
- ❌ Te detiene si hay tests fallidos
- 💡 Feedback inmediato en terminal

### 📊 **Feedback Post-push**
- ✅ Commit status visible en GitHub
- 💬 Comentarios automáticos en commits
- 📋 Issues automáticos si fallan tests
- 📊 Dashboard visual actualizado

**👉 [Guía completa de feedback](FEEDBACK-SISTEMA.md)**

---

## 📖 Kata Instructions

Read the complete instructions here:
- **File**: `.github/kata-definitions/kata-01-fizzbuzz.md`
- Or view it on GitHub in your repository

**Quick Summary**: Implement a function that returns a list from 1 to n, replacing multiples of 3 with "Fizz", multiples of 5 with "Buzz", and multiples of 15 with "FizzBuzz".

---

## 💻 Working on This Kata

### TDD Workflow (Red → Green → Refactor)

1. **Read the requirements** in `.github/kata-definitions/kata-01-fizzbuzz.md`
2. **Run tests**: `dotnet test` (they should fail - Red ❌)
3. **Write minimal code** in `FizzBuzz/FizzBuzz.cs` to make tests pass
4. **Run tests again**: `dotnet test` (they should pass - Green ✅)
5. **Refactor** your code to improve it
6. **Repeat** until all requirements are met

### Files to Edit

- `FizzBuzz/FizzBuzz.cs` - Your implementation goes here
- `FizzBuzz.Tests/FizzBuzzTests.cs` - Add more tests as you progress

### When You're Done

```bash
# Commit your work (hooks run tests automatically if installed)
git add .
git commit -m "Implement FizzBuzz kata"

# Push to trigger evaluation
git push origin master
```

**GitHub Actions** will:
- ✅ Run your tests
- ✅ Run additional hidden tests  
- ✅ Give you immediate feedback in multiple channels
- ✅ If all pass: Unlock Kata 02 automatically! 🎉

---

## 🎓 Learning Objectives

- Practice Test-Driven Development (TDD)
- Learn the Red-Green-Refactor cycle
- Experience incremental development
- Build confidence with automated testing

---

## 📚 Resources

- **Feedback System**: [`FEEDBACK-SISTEMA.md`](FEEDBACK-SISTEMA.md) - How to get immediate feedback
- **Progress Dashboard**: [`PROGRESS.md`](PROGRESS.md) - See your journey, badges, and tips
- **Kata Instructions**: `.github/kata-definitions/kata-01-fizzbuzz.md`
- **Your Code**: `FizzBuzz/FizzBuzz.cs`
- **Tests**: `FizzBuzz.Tests/FizzBuzzTests.cs`

---

Happy coding! 🚀💪
