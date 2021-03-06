// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewaySslPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DisabledSslProtocols != null)
            {
                writer.WritePropertyName("disabledSslProtocols");
                writer.WriteStartArray();
                foreach (var item in DisabledSslProtocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (PolicyType != null)
            {
                writer.WritePropertyName("policyType");
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (PolicyName != null)
            {
                writer.WritePropertyName("policyName");
                writer.WriteStringValue(PolicyName.Value.ToString());
            }
            if (CipherSuites != null)
            {
                writer.WritePropertyName("cipherSuites");
                writer.WriteStartArray();
                foreach (var item in CipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (MinProtocolVersion != null)
            {
                writer.WritePropertyName("minProtocolVersion");
                writer.WriteStringValue(MinProtocolVersion.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static ApplicationGatewaySslPolicy DeserializeApplicationGatewaySslPolicy(JsonElement element)
        {
            IList<ApplicationGatewaySslProtocol> disabledSslProtocols = default;
            ApplicationGatewaySslPolicyType? policyType = default;
            ApplicationGatewaySslPolicyName? policyName = default;
            IList<ApplicationGatewaySslCipherSuite> cipherSuites = default;
            ApplicationGatewaySslProtocol? minProtocolVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("disabledSslProtocols"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewaySslProtocol> array = new List<ApplicationGatewaySslProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApplicationGatewaySslProtocol(item.GetString()));
                    }
                    disabledSslProtocols = array;
                    continue;
                }
                if (property.NameEquals("policyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyType = new ApplicationGatewaySslPolicyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyName = new ApplicationGatewaySslPolicyName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cipherSuites"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplicationGatewaySslCipherSuite> array = new List<ApplicationGatewaySslCipherSuite>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ApplicationGatewaySslCipherSuite(item.GetString()));
                    }
                    cipherSuites = array;
                    continue;
                }
                if (property.NameEquals("minProtocolVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minProtocolVersion = new ApplicationGatewaySslProtocol(property.Value.GetString());
                    continue;
                }
            }
            return new ApplicationGatewaySslPolicy(disabledSslProtocols, policyType, policyName, cipherSuites, minProtocolVersion);
        }
    }
}
