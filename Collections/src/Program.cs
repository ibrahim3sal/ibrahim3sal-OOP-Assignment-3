
string?[] phoneNumbers =
{
    "01012345678",
    "+201512345678",
    "01312345678",
    "0101234567",
    "0101234567a",
    null,
    "",
    "   "
};

string?[] nationalIds =
{
    "29901011234567",
    "19901011234567",
    "2990101123456",
    null,
    "",
    "   "
};

foreach (string? phone in phoneNumbers)
{
    Console.WriteLine(
        $"Phone: {phone ?? "invalid"} => {phone.IsValidEgyptianPhone()}");
}

Console.WriteLine();

foreach (string? nationalId in nationalIds)
{
    Console.WriteLine(
        $"National ID: {nationalId ?? "invalid"} => {nationalId.IsValidEgyptianNationalId()}");
}
