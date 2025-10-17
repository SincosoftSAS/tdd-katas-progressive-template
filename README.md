# 🎯 TDD Journey - Progressive Katas# ��� TDD Journey - Progressive Katas



Welcome to your personal TDD learning journey!Welcome to your personal TDD learning journey!



## 📖 What is This?## ��� What is This?



Complete coding katas one at a time, unlocking new ones as you progress.Complete coding katas one at a time, unlocking new ones as you progress.



## 📊 Your Progress## ��� Your Progress



### ✅ Completed Katas### ✅ Completed Katas

_No katas completed yet. Start with Kata 01!__No katas completed yet. Start with Kata 01!_



### 🔓 Current Kata### ��� Available Katas

**Kata 01: FizzBuzz** - You're here! 🎯1. **Kata 01: FizzBuzz** - Start here!



### 🔒 Locked Katas### ��� Locked Katas

_Complete current kata to unlock the next one...__Complete current kata to unlock the next one..._



---## ��� Getting Started



## 🚀 Getting Started```bash

# Clone this repository

You're already in the right place! This repository contains **Kata 01: FizzBuzz**.git clone YOUR_REPO_URL

cd YOUR_REPO

### Prerequisites

- .NET 8.0 SDK or later# Switch to first kata

- Your favorite code editor (VS Code, Visual Studio, Rider, etc.)git checkout kata-01-fizzbuzz



### Setup# Read instructions

cat katas/01-fizzbuzz/README.md

```bash```

# Restore dependencies

dotnet restore## ��� Working on a Kata



# Build the project1. Switch to kata branch

dotnet build2. Read README.md

3. Follow TDD (Red → Green → Refactor)

# Run tests (they should fail initially - that's expected!)4. Run tests locally

dotnet test5. Push for evaluation

```6. Next kata unlocks automatically!



---Happy coding! �����


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
# Commit your work
git add .
git commit -m "Implement FizzBuzz kata"

# Push to trigger evaluation
git push origin master
```

**GitHub Actions** will:
- ✅ Run your tests
- ✅ Run additional hidden tests
- ✅ If all pass: Unlock Kata 02 automatically! 🎉

---

## 🎓 Learning Objectives

- Practice Test-Driven Development (TDD)
- Learn the Red-Green-Refactor cycle
- Experience incremental development
- Build confidence with automated testing

---

Happy coding! 🚀💪
