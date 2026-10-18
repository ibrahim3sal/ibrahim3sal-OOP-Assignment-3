using RefactoringLab;

var shipping = new ShippingCostCalculator();

Console.WriteLine($"Aramex 2kg → {shipping.Calculate(new AramexCarrier(), 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(new FedExCarrier(), 2)}");
Console.WriteLine($"UPS 2kg    → {shipping.Calculate(new UpsCarrier(), 2)}");
Console.WriteLine();

var processor = new OrderProcessor(
    new SqlOrderRepository(),
    new SmtpEmailSender());

processor.Process(1001, "customer@example.com");
Console.WriteLine();

var emailNotification = new Notification(new EmailNotification());

emailNotification.Send(
    "customer@example.com",
    "Your order ships tomorrow",
    urgent: true,
    sendAt: DateTime.Today.AddHours(18));

var smsNotification = new Notification(new SmsNotification());

smsNotification.Send(
    "+201000000000",
    "OTP 4821",
    urgent: true);

var pushNotification = new Notification(new PushNotification());

pushNotification.Send(
    "user123",
    "You have a new update",
    sendAt: DateTime.Today.AddHours(20));