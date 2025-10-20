# 🎯 TDD Journey - Progressive Katas

Welcome to your personal TDD learning journey! Master Test-Driven Development by completing katas one at a time.

## 📁 Simple Structure

```
katas/
├── kata-1/          # 🔓 UNLOCKED - Start here!
│   ├── README.md    # Instructions  
│   ├── src/         # Your code
│   └── tests/       # Tests
├── kata-2/          # 🔒 Unlocks when kata-1 is complete
├── kata-3/          # 🔒 And so on...
└── ...
```

## 🚀 Getting Started

```bash
# Work on current kata
cd katas/kata-1

# Run tests (should fail initially - that's TDD!)
dotnet test

# Write code in src/ to make tests pass
# Follow: Red → Green → Refactor

# When all tests pass, kata-2 unlocks automatically!
```

## 💻 Working on a Kata

### TDD Workflow (Red → Green → Refactor)

1. **Read**: Check the kata's `README.md` for instructions
2. **Red**: Run `dotnet test` - tests should fail ❌
3. **Green**: Write minimal code to make tests pass ✅
4. **Refactor**: Improve code while keeping tests green 🔄
5. **Repeat**: Until all requirements are met

### Automatic Features

- ✅ **Commit Status**: See results directly on GitHub
- 📋 **Auto Issues**: Get help when tests fail  
- 🔓 **Auto Unlock**: Next kata appears when current is complete
- 📊 **Progress Tracking**: `.github/progress.json` keeps score

## 🔄 Simple Workflow

```bash
# 1. Work on current kata
cd katas/kata-1

# 2. Follow TDD cycle
dotnet test          # See failing tests
# Write code in src/
dotnet test          # See tests pass

# 3. Push when ready
git add .
git commit -m "Complete kata-1"
git push origin master

# 4. Next kata unlocks automatically! 🎉
```

## 📊 Your Progress

- **Current kata**: Check `.github/progress.json`
- **Completed katas**: Shown in same file
- **Visual feedback**: Commit status on GitHub
- **Help**: Auto-created issues when tests fail

## 🎓 Learning Objectives

- Master Test-Driven Development (TDD)
- Learn the Red-Green-Refactor cycle
- Experience incremental development
- Build confidence with automated testing

## 📚 Optional Enhancements

- **Pre-commit hooks**: Install with `./install-hooks.sh` for local feedback
- **Detailed feedback**: See `FEEDBACK-SISTEMA.md` for all feedback channels

---

Happy coding! 🚀💪