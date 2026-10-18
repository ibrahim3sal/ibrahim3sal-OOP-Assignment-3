# Part 02 — answers

---

## Reports

- **What was the problem?**  
  The three report exporters duplicated the same workflow: loading data, validating it, formatting it, and saving it. This made the code harder to maintain because changes to the common workflow had to be repeated in multiple classes.

- **What did you change?**  
  I created an abstract class called `ReportExporter` containing the shared export workflow. The three exporters inherit from it and implement their own `Format` method.

- **Why did you choose that approach?**  
  I chose the Template Method pattern because it centralizes the common steps and keeps their execution order in one place. An abstract class allows shared implementation while requiring each exporter to provide its own formatting logic.

---

## Enrollment

- **What was the problem?**  
  `Program.cs` created four services and called them individually in a specific order. This exposed the enrollment workflow's complexity to the caller and tightly coupled the caller to the services.

- **What did you change?**  
  I created an `EnrollmentFacade` that coordinates `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService` through a single `Enroll` method. The four existing services remain unchanged.

- **Why did you choose that approach?**  
  I chose the Facade pattern because it provides a simple interface for a complex workflow. The caller no longer needs to create the services, call them individually, or know the order in which they must execute.