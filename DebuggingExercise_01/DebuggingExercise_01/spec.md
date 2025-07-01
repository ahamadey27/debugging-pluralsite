# Debugging Exercises Specification

## Overview
This exercise will help you practice using Visual Studio's debugging tools to identify and fix bugs in C# code. You will work through 10 small exercises, each in its own file, and use the debugging features of Visual Studio to solve them.

## Phases

### Phase 1: Setup
- Open the solution in Visual Studio.
- Build the project to ensure all files compile.
- Familiarize yourself with the __Program.cs__ file, which allows you to select and run each exercise.

### Phase 2: Select an Exercise
- Run the application.
- When prompted, enter a number (1-10) to select a debugging exercise.
- The corresponding exercise will execute.

### Phase 3: Debugging
- When the exercise runs, observe the output or behavior.
- If the program does not behave as expected, use Visual Studio's debugging tools:
  - **Breakpoints:** Set breakpoints to pause execution at specific lines.
  - **Watches:** Add variables to the __Watch__ window to monitor their values.
  - **Call Stack:** Use the __Call Stack__ window to see the sequence of method calls.
  - **Autos/Locals:** Inspect the __Autos__ and __Locals__ windows to view variable values in the current scope.
  - **Step Into/Over/Out:** Use these commands to control execution flow line by line.

### Phase 4: Identify and Fix the Bug
- Use the information from the debugging tools to find the bug.
- Edit the code to fix the issue.
- Re-run the exercise to verify the fix.

### Phase 5: Reflect
- After fixing each bug, write a brief note (as a comment) in the exercise file about what the bug was and how you found it.

## Tips
- Use __Debug > Windows__ to open any debugging window you need.
- Right-click variables and select "Add Watch" for closer inspection.
- Use __Immediate Window__ to evaluate expressions at runtime.

## Goal
By the end of these exercises, you should be comfortable using Visual Studio's debugging tools to diagnose and fix common programming errors.