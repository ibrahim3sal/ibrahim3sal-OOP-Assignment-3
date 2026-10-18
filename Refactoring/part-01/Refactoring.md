# Part 01 — answers

---

## ShippingCostCalculator

- **What was the problem?**  
  The `ShippingCostCalculator` used a `switch` statement to calculate shipping costs for specific carriers. Adding a new carrier required modifying the existing class, violating the Open/Closed Principle (OCP).

- **What did you change?**  
  I introduced the `IShippingCarrier` interface and made each carrier implement its own cost calculation. The `ShippingCostCalculator` now depends on the interface instead of hard-coded carrier names.

---

## OrderProcessor

- **What was the problem?**  
  The `OrderProcessor` created its own dependencies using `new`, making it tightly coupled to the SQL repository and SMTP email sender implementations.

- **What did you change?**  
  I introduced the `IOrderRepository` and `IEmailSender` interfaces and injected the dependencies through the constructor. This applies the Dependency Inversion Principle (DIP) and makes the class easier to extend and test.

---

## Notifications

- **What was the problem?**  
  The notification classes used inheritance to combine notification channels with urgent and scheduled behaviors. This created separate classes for different combinations and made adding new combinations difficult.

- **What did you change?**  
  I used composition by separating the notification channel from the notification behavior. The `Notification` class now accepts an `INotificationChannel` and supports urgent and scheduled notifications without creating a separate class for each combination.

---

## Proof

- New carrier file(s): `ShippingCarriers.cs` (contains `UpsCarrier`).
- New notification channel file(s): `PushNotification.cs` (contains `PushNotification`).
- Existing classes left unchanged? Yes