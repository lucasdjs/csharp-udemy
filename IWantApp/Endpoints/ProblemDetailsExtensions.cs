using Flunt.Notifications;

namespace IWantApp.Endpoints;

public static class ProblemDetailsExtensions
{
    public static Dictionary<string, string[]> ConvertToProblemDetails(this IReadOnlyCollection<Notification> notifications)
    {
        return notifications
            .GroupBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Select(x => x.Message).ToArray());
    }
}
