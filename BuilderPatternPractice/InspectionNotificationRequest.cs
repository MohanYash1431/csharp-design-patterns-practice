namespace BuilderPatternPractice
{
    public sealed class InspectionNotificationRequest
    {
        public string Title { get; }
        public string Message { get; }
        public Guid InspectorId { get; }
        public string? Topic { get; }
        public string? CardNumber { get; }
        public bool IsImpotant { get; }

        private InspectionNotificationRequest(Builder builder)
        {
            Title = builder.Title;
            Message = builder.Message;
            InspectorId = builder.InspectorId;
            Topic = builder.Topic;
            CardNumber = builder.CardNumber;
            IsImpotant = builder.IsImpotant;
        }

        public sealed class Builder
        {
            internal string Title { get; }
            internal string Message { get; }
            internal Guid InspectorId { get; private set; }
            internal string? Topic { get; private set; }
            internal string? CardNumber { get; private set; }
            internal bool IsImpotant { get; private set; }
            public Builder(string title, string message, Guid inspectorId)
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    throw new ArgumentException("Title cannot be null or empty.", nameof(title));
                }
                if (string.IsNullOrWhiteSpace(message))
                {
                    throw new ArgumentException("Message cannot be null or empty.", nameof(message));
                }
                Title = title;
                Message = message;
                InspectorId = inspectorId;
            }
            public Builder SetTopic(string topic)
            {
                Topic = topic;
                return this;
            }
            public Builder SetCardNumber(string cardNumber)
            {
                CardNumber = cardNumber;
                return this;
            }
            public Builder SetIsImportant(bool isImportant)
            {
                IsImpotant = isImportant;
                return this;
            }
            public InspectionNotificationRequest Build()
            {
                return new InspectionNotificationRequest(this);
            }
        }
    }
}
