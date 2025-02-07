namespace Yandex.Messenger.Bot.Sdk.Models.Requests;

/// <summary>
/// Represents a message sending request data.
/// </summary>
public record SendMessageRequest : Request
{
    /// <summary>
    /// The text of the message.
    /// </summary>
    public required string Text { get; init; }

    /// <summary>
    /// A payload ID.
    /// </summary>
    public string? PayloadId { get; init; }

    /// <summary>
    /// The ID of a message which should be replied.
    /// </summary>
    public string? ReplyMessageId { get; init; }

    /// <summary>
    /// Indicates that notifications of the message should be disabled.
    /// </summary>
    public bool DisableNotification { get; init; } = false;

    /// <summary>
    /// Indicates that the message is important.
    /// </summary>
    public bool Important { get; init; } = false;

    /// <summary>
    /// Indicates that in the message should be disabled a preview.
    /// </summary>
    public bool DisableWebPagePreview { get; init; } = false;

    /// <summary>
    /// An array of inline buttons which should be shown bottom of the message.
    /// </summary>
    public Button[] InlineKeyboard { get; init; } = Array.Empty<Button>();
}