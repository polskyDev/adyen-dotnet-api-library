﻿using System;
using Adyen.EcommLibrary.Model.Nexo.Message;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.CloudApiSerialization.Converter
{
    internal class SaleToPoiMessageConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            serializer.NullValueHandling = NullValueHandling.Ignore;

            writer.WriteStartObject();
            writer.WritePropertyName(value.GetType().Name);

            writer.WriteStartObject();

            var saleToPoiMessage = value as SaleToPoiMessage;

            writer.WritePropertyName(saleToPoiMessage.MessageHeader.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessageHeader);

            writer.WritePropertyName(saleToPoiMessage.MessagePayload.GetType().Name);
            serializer.Serialize(writer, saleToPoiMessage.MessagePayload);

            writer.WriteEndObject();

            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(SaleToPoiMessage).IsAssignableFrom(objectType); ;
        }
    }
}
