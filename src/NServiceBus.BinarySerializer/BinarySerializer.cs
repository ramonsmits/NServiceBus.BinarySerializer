namespace NServiceBus
{
    using System;
    using NServiceBus.MessageInterfaces;
    using NServiceBus.Serialization;
    using NServiceBus.Settings;

    /// <summary>
    /// Defines the capabilities of the Binary serializer
    /// </summary>
    public class BinarySerializer : SerializationDefinition
    {
        /// <summary>
        /// Provides a factory method for building a message serializer.
        /// </summary>
        public override Func<IMessageMapper, IMessageSerializer> Configure(ReadOnlySettings settings)
        {
            if(settings==null) throw new ArgumentNullException(nameof(settings));
            return mapper => new Serializers.Binary.BinaryMessageSerializer();
        }
    }
}