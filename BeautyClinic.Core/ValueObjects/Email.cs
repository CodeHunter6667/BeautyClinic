using System.Text.RegularExpressions;

namespace BeautyClinic.Core.ValueObjects;

public partial class Email
{
    public const int MaxLength = 254;
    public string Address { get; private set; } = string.Empty;

    protected Email() { }

    public Email(string address)
    {
        if (string.IsNullOrWhiteSpace(address))
            throw new ArgumentException("Email address cannot be empty.", nameof(address));

        var trimmedAddress = address.Trim();

        if (trimmedAddress.Length > MaxLength)
            throw new ArgumentException($"Email address cannot exceed {MaxLength} characters.", nameof(address));

        if (!IsValid(trimmedAddress))
            throw new ArgumentException("Invalid email format.", nameof(address));

        Address = trimmedAddress;
    }

    public static bool IsValid(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        // Simple and effective regex for email validation
        // Pattern: 
        // ^ - Start of line
        // [^@\s]+ - One or more characters that are not @ or whitespace
        // @ - The @ symbol
        // [^@\s]+ - One or more characters that are not @ or whitespace
        // \. - A dot
        // [^@\s]+ - One or more characters that are not @ or whitespace
        // $ - End of line
        var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        return regex.IsMatch(email);
    }

    public override string ToString() => Address;

    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is not Email other) return false;
        return Address.Equals(other.Address, StringComparison.OrdinalIgnoreCase);
    }

    public override int GetHashCode() => StringComparer.OrdinalIgnoreCase.GetHashCode(Address);

    public static implicit operator string(Email email) => email.Address;

    public static explicit operator Email(string address) => new(address);
}
