# Debugging Exercises Outline

This guide provides step-by-step instructions for debugging each exercise, including why the bug occurs, how to approach debugging, and which Visual Studio tools to use.

---

## General Debugging Shortcuts

- **Start Debugging:** `F5`
- **Step Over:** `F10`
- **Step Into:** `F11`
- **Step Out:** `Shift+F11`
- **Toggle Breakpoint:** `F9`
- **Continue:** `F5`
- **Open Watch Window:** `Ctrl+Alt+W, 1`
- **Open Locals Window:** `Ctrl+Alt+V, L`
- **Open Autos Window:** `Ctrl+Alt+V, A`
- **Open Call Stack Window:** `Ctrl+Alt+C`
- **Immediate Window:** `Ctrl+Alt+I`

---

## Exercise 01: Off-by-One Error in Loop

**Why this bug happens:**  
The loop starts at `i = 0` and runs while `i <= 10`, so it includes 0 and 10. 
The sum should be from 1 to 10, but this code adds an extra 0 at the start.

**How to debug:**
1. Set a breakpoint on the `for` loop line (`F9`).
2. Start debugging (`F5`).
3. Use **Step Over** (`F10`) to walk through each iteration.
4. Watch the value of `i` and `sum` in the **Locals** or **Watch** window (`Ctrl+Alt+V, L`).
5. Notice that the first value added is 0, and the loop includes 10.
6. Reason: The loop should start at 1, not 0, to match the intended range.

**Why this approach:**  
Stepping through the loop and watching variable values helps you see exactly which numbers are being added, 
making it clear where the off-by-one error occurs.

---

## Exercise 02: Null Reference Exception

**Why this bug happens:**  
The variable `message` is assigned `null`, and calling `ToUpper()` on a null reference throws a `NullReferenceException`.

**How to debug:**
1. Set a breakpoint on the `Console.WriteLine(message.ToUpper())` line.
2. Start debugging.
3. Hover over `message` or check the **Locals** window to see its value.
4. When the exception occurs, Visual Studio will highlight the line and show the exception details.
5. Reason: You cannot call methods on a null object.

**Why this approach:**  
Inspecting variable values before method calls helps you catch null references early and understand why the exception is thrown.

---

## Exercise 03: Array Index Out of Bounds

**Why this bug happens:**  
The loop runs from `i = 0` to `i <= numbers.Length`, which means it tries to access `numbers[3]` (out of bounds for a 3-element array).

**How to debug:**
1. Set a breakpoint inside the loop.
2. Start debugging.
3. Use **Step Over** to iterate through the loop.
4. Watch the value of `i` and `numbers.Length` in the **Locals** window.
5. When the exception occurs, check the **Call Stack** window to see where the error happened.
6. Reason: Arrays are zero-indexed, so the last valid index is `Length - 1`.

**Why this approach:**  
Stepping through the loop and watching the index helps you see when and why the out-of-bounds access occurs.

---

## Exercise 04: Division by Zero

**Why this bug happens:**  
The variable `b` is set to 0, and dividing by zero throws a `DivideByZeroException`.

**How to debug:**
1. Set a breakpoint on the division line.
2. Start debugging.
3. Inspect the values of `a` and `b` in the **Locals** window.
4. When the exception occurs, Visual Studio will show the error.
5. Reason: Division by zero is undefined in mathematics and not allowed in C#.

**Why this approach:**  
Checking variable values before performing operations helps prevent runtime exceptions.

---

## Exercise 05: Incorrect String Comparison

**Why this bug happens:**  
The comparison `input == "hello"` is case-sensitive, so `"Hello"` does not equal `"hello"`.

**How to debug:**
1. Set a breakpoint on the `if` statement.
2. Start debugging.
3. Inspect the value of `input` in the **Locals** window.
4. Use the **Immediate Window** to test different string comparisons.
5. Reason: String comparisons are case-sensitive by default in C#.

**Why this approach:**  
Testing expressions in the Immediate Window and inspecting variable values helps you understand how string comparisons work.

---

## Exercise 06: Infinite Loop

**Why this bug happens:**  
The loop variable `i` is never incremented, so the condition `i < 5` is always true, resulting in an infinite loop.

**How to debug:**
1. Set a breakpoint inside the `while` loop.
2. Start debugging.
3. Use **Step Over** to observe the value of `i` in the **Locals** window.
4. Notice that `i` never changes.
5. Reason: The loop variable must be updated to eventually break the loop.

**Why this approach:**  
Watching loop variables during execution helps you catch infinite loops and understand why they occur.

---

## Exercise 07: Logic Error in Condition

**Why this bug happens:**  
The condition `age > 18 && age < 18` can never be true, so the code always prints "You are not 18."

**How to debug:**
1. Set a breakpoint on the `if` statement.
2. Start debugging.
3. Inspect the value of `age` in the **Locals** window.
4. Use the **Immediate Window** to test the condition.
5. Reason: The logic in the condition is incorrect; it should check for equality or a valid range.

**Why this approach:**  
Testing conditions in the Immediate Window helps you quickly identify logic errors.

---

## Exercise 08: Incorrect Calculation (Integer Division)

**Why this bug happens:**  
`x / y` performs integer division, so `5 / 2` results in `2`, not `2.5`. Assigning this to a `double` does not fix the calculation.

**How to debug:**
1. Set a breakpoint on the division line.
2. Start debugging.
3. Inspect the values of `x`, `y`, and `result` in the **Locals** window.
4. Use the **Immediate Window** to try `x / (double)y`.
5. Reason: Both operands must be cast to `double` for floating-point division.

**Why this approach:**  
Trying different expressions in the Immediate Window helps you understand how C# handles division.

---

## Exercise 09: Unhandled Exception (Null Array)

**Why this bug happens:**  
The array `arr` is `null`, so accessing `arr.Length` throws a `NullReferenceException`.

**How to debug:**
1. Set a breakpoint on the line accessing `arr.Length`.
2. Start debugging.
3. Inspect the value of `arr` in the **Locals** window.
4. When the exception occurs, check the **Call Stack** window.
5. Reason: You cannot access members of a null object.

**Why this approach:**  
Inspecting object references before accessing their members helps prevent null reference errors.

---

## Exercise 10: Invalid Date Parsing

**Why this bug happens:**  
The string `"2025-02-30"` is not a valid date, so `DateTime.Parse` throws a `FormatException`.

**How to debug:**
1. Set a breakpoint on the `DateTime.Parse` line.
2. Start debugging.
3. Use the **Immediate Window** to try parsing different date strings.
4. When the exception occurs, check the exception details.
5. Reason: February never has 30 days.

**Why this approach:**  
Testing input values and handling exceptions helps you write more robust code.

---

**Tip:** For any unfamiliar debugging window, open it from the __Debug > Windows__ menu or use the shortcut listed above.
