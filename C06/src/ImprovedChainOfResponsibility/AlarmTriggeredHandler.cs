﻿namespace ImprovedChainOfResponsibility
{
    public class AlarmTriggeredHandler : IMessageHandler
    {
        private readonly IMessageHandler _next;
        public AlarmTriggeredHandler(IMessageHandler next = null)
        {
            _next = next;
        }

        public void Handle(Message message)
        {
            if (message.Name == "AlarmTriggered")
            {
                // Do something cleaver with the Payload
            }
            else if (_next != null)
            {
                _next.Handle(message);
            }
        }
    }
}
