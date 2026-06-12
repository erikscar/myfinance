namespace myfinance.Shared.Results;

public sealed record Failure(string Message)
{
    public static Failure UserNotFound => new("User not Found");
    public static Failure PasswordIncorrect => new("Incorrect Password");
}