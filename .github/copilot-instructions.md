# Copilot Instructions

## Project Guidelines
- The user's payroll system requires payroll computations to be saved and displayed across multiple forms. The implementation uses CurrentUser static class to store payroll data (HourlyRate, BasicSalary, WithholdingTax, PhilHealth, SSS, PagIbig, TotalDeductions, NetPay) that persists during the user session. The Payroll form computes and saves these values, the Home form displays them in the Employee Payroll Preview panel, and the Salary Deductions form displays them with a detailed breakdown in a DataGridView.