# 🎓 University Quiz System
### C# Windows Forms Application — OOP Course Project

---

## 📁 Project Structure

```
UniversityQuizSystem/
│
├── Program.cs                      ← Entry point
│
├── Models/
│   ├── Enumerations.cs             ← All enums (UserRole, StudyYear, Semester, QuestionType, ClassType)
│   ├── User.cs                     ← Base class
│   ├── Student.cs                  ← Inherits from User
│   ├── Lecturer.cs                 ← Inherits from User
│   ├── Question.cs                 ← Question class with file serialization
│   └── Quiz.cs                     ← Array of Question objects + FileManager
│
└── Forms/
    ├── LoginForm.cs / .Designer.cs         ← Role-based login
    ├── SelectionForm.cs / .Designer.cs     ← Year, Semester, Subject, Section
    ├── LecturerForm.cs / .Designer.cs      ← Add & save questions
    ├── StudentForm.cs / .Designer.cs       ← Take quiz, navigate questions
    └── ResultForm.cs / .Designer.cs        ← Show score, grade, save result
```

---

## 🧩 OOP Concepts Demonstrated

### 1. Classes
| Class | File | Purpose |
|-------|------|---------|
| `User` | Models/User.cs | Base class with shared properties |
| `Student` | Models/Student.cs | Student-specific behavior |
| `Lecturer` | Models/Lecturer.cs | Lecturer-specific behavior |
| `Question` | Models/Question.cs | Stores question data |
| `Quiz` | Models/Quiz.cs | Manages array of Questions |
| `FileManager` | Models/Quiz.cs | Static class for file I/O |

### 2. Inheritance
```
User  (base class)
 ├── Student   (UserRole.Student)
 └── Lecturer  (UserRole.Lecturer)
```
- `User` has a virtual method `GetInfo()`
- Both `Student` and `Lecturer` **override** `GetInfo()`
- `LoginForm` creates either a `Student` or `Lecturer` object

### 3. Enumerations
```csharp
enum UserRole    { Student, Lecturer }
enum StudyYear   { First, Second, Third, Fourth }
enum Semester    { First, Second }
enum QuestionType{ MultipleChoice, Essay }
enum ClassType   { Lecture, Section }
```

### 4. Array of Objects
In `Quiz.cs`:
```csharp
private Question[] questions;   // Array of Question objects
private int count;
private const int MAX_QUESTIONS = 50;
```
Questions are added, retrieved, and iterated using this array.

### 5. File Handling
- **Questions** are saved to: `OOP_First_First_Section1_questions.txt`
- **Results** are appended to: `results.txt`

Saved result format:
```
Ahmed Ali - OOP - Score: 8/10
```

---

## ▶️ How to Run

### Requirements
- Visual Studio 2022 (or VS Code with C# extension)
- .NET 6.0 SDK or later (Windows)

### Steps
1. Open Visual Studio
2. Open the folder `UniversityQuizSystem/`
3. Double-click `UniversityQuizSystem.csproj`
4. Press **F5** to build and run

---

## 🖥️ Application Flow

```
[LoginForm]
  Enter Name + Select Role (Student / Lecturer)
       ↓
[SelectionForm]
  Choose: Year → Semester → Subject → Lecture/Section → Section No.
       ↓
  ┌────────────┬────────────┐
  │  LECTURER  │  STUDENT   │
  │            │            │
  │ Add MCQ /  │ Take Quiz  │
  │ Essay Q's  │ Navigate   │
  │            │ Questions  │
  │ Save to    │            │
  │ File       │ Submit     │
  └────────────┴────────────┘
                    ↓
              [ResultForm]
         Shows Score / Grade
         Saves to results.txt
```

---

## 📌 Notes for Your Submission
- The system links lecturer questions to students via a shared filename key (Subject + Year + Semester + Section).
- Essay questions are displayed but not auto-graded.
- Multiple Choice questions are auto-graded and counted in the final score.
