// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryArtifactPublishingProfileBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (TargetRegions != null)
            {
                writer.WritePropertyName("targetRegions");
                writer.WriteStartArray();
                foreach (var item in TargetRegions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ReplicaCount != null)
            {
                writer.WritePropertyName("replicaCount");
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (ExcludeFromLatest != null)
            {
                writer.WritePropertyName("excludeFromLatest");
                writer.WriteBooleanValue(ExcludeFromLatest.Value);
            }
            if (PublishedDate != null)
            {
                writer.WritePropertyName("publishedDate");
                writer.WriteStringValue(PublishedDate.Value, "O");
            }
            if (EndOfLifeDate != null)
            {
                writer.WritePropertyName("endOfLifeDate");
                writer.WriteStringValue(EndOfLifeDate.Value, "O");
            }
            if (StorageAccountType != null)
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static GalleryArtifactPublishingProfileBase DeserializeGalleryArtifactPublishingProfileBase(JsonElement element)
        {
            IList<TargetRegion> targetRegions = default;
            int? replicaCount = default;
            bool? excludeFromLatest = default;
            DateTimeOffset? publishedDate = default;
            DateTimeOffset? endOfLifeDate = default;
            StorageAccountType? storageAccountType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetRegions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TargetRegion> array = new List<TargetRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(TargetRegion.DeserializeTargetRegion(item));
                        }
                    }
                    targetRegions = array;
                    continue;
                }
                if (property.NameEquals("replicaCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("excludeFromLatest"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    excludeFromLatest = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publishedDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publishedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endOfLifeDate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endOfLifeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountType = new StorageAccountType(property.Value.GetString());
                    continue;
                }
            }
            return new GalleryArtifactPublishingProfileBase(targetRegions, replicaCount, excludeFromLatest, publishedDate, endOfLifeDate, storageAccountType);
        }
    }
}
