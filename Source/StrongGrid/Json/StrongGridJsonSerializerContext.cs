using System.Text.Json.Serialization;

namespace StrongGrid.Json
{
	[JsonSerializable(typeof(string[]))]
	[JsonSerializable(typeof(long[]))]
	[JsonSerializable(typeof(bool))]

	[JsonSerializable(typeof(StrongGrid.Json.StrongGridJsonObject))]
	[JsonSerializable(typeof(StrongGrid.Json.StrongGridJsonObject[]))]

	[JsonSerializable(typeof(StrongGrid.Models.AccessEntry))]
	[JsonSerializable(typeof(StrongGrid.Models.AccessRequest))]
	[JsonSerializable(typeof(StrongGrid.Models.Account))]
	[JsonSerializable(typeof(StrongGrid.Models.AddIpAddressResult))]
	[JsonSerializable(typeof(StrongGrid.Models.AddressWhitelistSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.AggregateBy))]
	[JsonSerializable(typeof(StrongGrid.Models.Alert))]
	[JsonSerializable(typeof(StrongGrid.Models.AlertType))]
	[JsonSerializable(typeof(StrongGrid.Models.ApiKey))]
	[JsonSerializable(typeof(StrongGrid.Models.Attachment))]
	[JsonSerializable(typeof(StrongGrid.Models.AuthenticatedDomain))]
	[JsonSerializable(typeof(StrongGrid.Models.AuthenticatedDomainDns))]
	[JsonSerializable(typeof(StrongGrid.Models.BatchInfo))]
	[JsonSerializable(typeof(StrongGrid.Models.BatchStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.BccSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Block))]
	[JsonSerializable(typeof(StrongGrid.Models.Bounce))]
	[JsonSerializable(typeof(StrongGrid.Models.BouncePurgeSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.BounceType))]
	[JsonSerializable(typeof(StrongGrid.Models.BrandedLink))]
	[JsonSerializable(typeof(StrongGrid.Models.BrandedLinkDns))]
	[JsonSerializable(typeof(StrongGrid.Models.ClickTrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.ConditionOperator))]
	[JsonSerializable(typeof(StrongGrid.Models.Contact))]
	[JsonSerializable(typeof(StrongGrid.Models.CustomFieldMetadata))]
	[JsonSerializable(typeof(StrongGrid.Models.Design))]
	[JsonSerializable(typeof(StrongGrid.Models.DnsRecord))]
	[JsonSerializable(typeof(StrongGrid.Models.DomainValidation))]
	[JsonSerializable(typeof(StrongGrid.Models.DomainValidationResults))]
	[JsonSerializable(typeof(StrongGrid.Models.EditorType))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.BlockedEvent), TypeInfoPropertyName = "EmailActivitiesBlockedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.BounceEvent), TypeInfoPropertyName = "EmailActivitiesBounceEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.ClickEvent), TypeInfoPropertyName = "EmailActivitiesClickEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DeferredEvent), TypeInfoPropertyName = "EmailActivitiesDeferredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DeliveredEvent), TypeInfoPropertyName = "EmailActivitiesDeliveredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DroppedEvent), TypeInfoPropertyName = "EmailActivitiesDroppedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.Event), TypeInfoPropertyName = "EmailActivitiesEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.GroupResubscribeEvent), TypeInfoPropertyName = "EmailActivitiesGroupResubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.GroupUnsubscribeEvent), TypeInfoPropertyName = "EmailActivitiesGroupUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.OpenEvent), TypeInfoPropertyName = "EmailActivitiesOpenEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.ProcessedEvent), TypeInfoPropertyName = "EmailActivitiesProcessedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.SpamReportEvent), TypeInfoPropertyName = "EmailActivitiesSpamReportEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.UnsubscribeEvent), TypeInfoPropertyName = "EmailActivitiesUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivityStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailAddressSetting))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailMessageActivity))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailMessageSummary))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationAdditionalChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationDomainChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationLocalPartChecks))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationResult))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationVerdict))]
	[JsonSerializable(typeof(StrongGrid.Models.EnforcedTlsSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Error))]
	[JsonSerializable(typeof(StrongGrid.Models.EventType))]
	[JsonSerializable(typeof(StrongGrid.Models.EventWebhookSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportJob))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportJobStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportType))]
	[JsonSerializable(typeof(StrongGrid.Models.Field))]
	[JsonSerializable(typeof(StrongGrid.Models.FieldMetadata))]
	[JsonSerializable(typeof(StrongGrid.Models.FieldType))]
	[JsonSerializable(typeof(StrongGrid.Models.FileType))]
	[JsonSerializable(typeof(StrongGrid.Models.FooterGlobalSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.FooterSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Frequency))]
	[JsonSerializable(typeof(StrongGrid.Models.GlobalSetting))]
	[JsonSerializable(typeof(StrongGrid.Models.GlobalSuppression))]
	[JsonSerializable(typeof(StrongGrid.Models.GoogleAnalyticsGlobalSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.GoogleAnalyticsSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJob))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJobRequest))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJobStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportResults))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportType))]
	[JsonSerializable(typeof(StrongGrid.Models.InboundParseWebhookSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.InvalidEmail))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddress))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddressesRemaining))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddressType))]
	[JsonSerializable(typeof(StrongGrid.Models.IpPool))]
	[JsonSerializable(typeof(StrongGrid.Models.IpPoolAddress))]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Campaign), TypeInfoPropertyName = "LegacyCampaign")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.CampaignStatus), TypeInfoPropertyName = "LegacyCampaignStatus")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Contact), TypeInfoPropertyName = "LegacyContact")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.CustomFieldMetadata), TypeInfoPropertyName = "LegacyCustomFieldMetadata")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Field), TypeInfoPropertyName = "LegacyField")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.FieldMetadata), TypeInfoPropertyName = "LegacyFieldMetadata")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.ImportResult), TypeInfoPropertyName = "LegacyImportResult")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.List), TypeInfoPropertyName = "LegacyList")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.LogicalOperator), TypeInfoPropertyName = "LegacyLogicalOperator")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.SearchCondition), TypeInfoPropertyName = "LegacySearchCondition")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Segment), TypeInfoPropertyName = "LegacySegment")]
	[JsonSerializable(typeof(StrongGrid.Models.LinkValidation))]
	[JsonSerializable(typeof(StrongGrid.Models.LinkValidationResults))]
	[JsonSerializable(typeof(StrongGrid.Models.List))]
	[JsonSerializable(typeof(StrongGrid.Models.MailAddress))]
	[JsonSerializable(typeof(StrongGrid.Models.MailContent))]
	[JsonSerializable(typeof(StrongGrid.Models.MailPersonalization))]
	[JsonSerializable(typeof(StrongGrid.Models.MailPriority))]
	[JsonSerializable(typeof(StrongGrid.Models.MailSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.MonitorSettings))]
#pragma warning disable CS0618 // Type or member is obsolete
	[JsonSerializable(typeof(StrongGrid.Models.NewRelicSettings))]
#pragma warning restore CS0618 // Type or member is obsolete
	[JsonSerializable(typeof(StrongGrid.Models.OpenTrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.PaginationMetadata))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryLanguageVersion))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryValidationStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryValidationStatusType))]
	[JsonSerializable(typeof(StrongGrid.Models.ReservedFieldMetadata))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDns))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDnsValidation))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDnsValidationResults))]
	[JsonSerializable(typeof(StrongGrid.Models.Search.ContactsFilterField), TypeInfoPropertyName = "SearchContactsFilterField")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.EmailActivitiesFilterField), TypeInfoPropertyName = "SearchEmailActivitiesFilterField")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.FilterTable), TypeInfoPropertyName = "SearchFilterTable")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchComparisonOperator), TypeInfoPropertyName = "SearchSearchComparisonOperator")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteria), TypeInfoPropertyName = "SearchSearchCriteria")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaBetween), TypeInfoPropertyName = "SearchSearchCriteriaBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaContains), TypeInfoPropertyName = "SearchSearchCriteriaContains")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaEqual), TypeInfoPropertyName = "SearchSearchCriteriaEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaGreaterEqual), TypeInfoPropertyName = "SearchSearchCriteriaGreaterEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaGreaterThan), TypeInfoPropertyName = "SearchSearchCriteriaGreaterThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaIn), TypeInfoPropertyName = "SearchSearchCriteriaIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaIsNotNull), TypeInfoPropertyName = "SearchSearchCriteriaIsNotNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaIsNull), TypeInfoPropertyName = "SearchSearchCriteriaIsNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaLessEqual), TypeInfoPropertyName = "SearchSearchCriteriaLessEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaLessThan), TypeInfoPropertyName = "SearchSearchCriteriaLessThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaLike), TypeInfoPropertyName = "SearchSearchCriteriaLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotBetween), TypeInfoPropertyName = "SearchSearchCriteriaNotBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotEqual), TypeInfoPropertyName = "SearchSearchCriteriaNotEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotIn), TypeInfoPropertyName = "SearchSearchCriteriaNotIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotLike), TypeInfoPropertyName = "SearchSearchCriteriaNotLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArg), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArg")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgBetween), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgEqual), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgGreaterEqual), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgGreaterEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgGreaterThan), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgGreaterThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgIn), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgLessEqual), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgLessEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgLessThan), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgLessThan")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgLike), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotBetween), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotBetween")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotEqual), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotEqual")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotIn), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotIn")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotLike), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotLike")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotNull), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNull), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNull")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchLogicalOperator), TypeInfoPropertyName = "SearchSearchLogicalOperator")]
	[JsonSerializable(typeof(StrongGrid.Models.Segment))]
	[JsonSerializable(typeof(StrongGrid.Models.SenderIdentity))]
	[JsonSerializable(typeof(StrongGrid.Models.SenderReputation))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSend))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendEmailConfig))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendSendTo))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamCheckingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamCheckSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamReport))]
	[JsonSerializable(typeof(StrongGrid.Models.Stat))]
	[JsonSerializable(typeof(StrongGrid.Models.Statistic))]
	[JsonSerializable(typeof(StrongGrid.Models.SubscriptionSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.SubscriptionTrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.Subuser))]
	[JsonSerializable(typeof(StrongGrid.Models.Suppression))]
	[JsonSerializable(typeof(StrongGrid.Models.SuppressionGroup))]
	[JsonSerializable(typeof(StrongGrid.Models.Teammate))]
	[JsonSerializable(typeof(StrongGrid.Models.TeammateInvitation))]
	[JsonSerializable(typeof(StrongGrid.Models.Template))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateType))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateVersion))]
	[JsonSerializable(typeof(StrongGrid.Models.TrackingSettings))]
	[JsonSerializable(typeof(StrongGrid.Models.UnsubscribeOptions))]
	[JsonSerializable(typeof(StrongGrid.Models.UserCredits))]
	[JsonSerializable(typeof(StrongGrid.Models.UserProfile))]
	[JsonSerializable(typeof(StrongGrid.Models.ValidationResult))]
	[JsonSerializable(typeof(StrongGrid.Models.VerificationStatus))]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.BouncedEvent), TypeInfoPropertyName = "WebhooksBouncedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.ClickedEvent), TypeInfoPropertyName = "WebhooksClickedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeferredEvent), TypeInfoPropertyName = "WebhooksDeferredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeliveredEvent), TypeInfoPropertyName = "WebhooksDeliveredEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeliveryEvent), TypeInfoPropertyName = "WebhooksDeliveryEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DroppedEvent), TypeInfoPropertyName = "WebhooksDroppedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.EngagementEvent), TypeInfoPropertyName = "WebhooksEngagementEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.Event), TypeInfoPropertyName = "WebhooksEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.GroupResubscribeEvent), TypeInfoPropertyName = "WebhooksGroupResubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.GroupUnsubscribeEvent), TypeInfoPropertyName = "WebhooksGroupUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmail), TypeInfoPropertyName = "WebhooksInboundEmail")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmailAttachment), TypeInfoPropertyName = "WebhooksInboundEmailAttachment")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmailEnvelope), TypeInfoPropertyName = "WebhooksInboundEmailEnvelope")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.IpPool), TypeInfoPropertyName = "WebhooksIpPool")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.Newsletter), TypeInfoPropertyName = "WebhooksNewsletter")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.OpenedEvent), TypeInfoPropertyName = "WebhooksOpenedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.ProcessedEvent), TypeInfoPropertyName = "WebhooksProcessedEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.SpamReportEvent), TypeInfoPropertyName = "WebhooksSpamReportEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UnsubscribeEvent), TypeInfoPropertyName = "WebhooksUnsubscribeEvent")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UrlOffset), TypeInfoPropertyName = "WebhooksUrlOffset")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UrlType), TypeInfoPropertyName = "WebhooksUrlType")]
	[JsonSerializable(typeof(StrongGrid.Models.WhitelistedIp))]

	[JsonSerializable(typeof(StrongGrid.Models.AccessEntry[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AccessRequest[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Account[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AddIpAddressResult[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AddressWhitelistSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AggregateBy[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Alert[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AlertType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ApiKey[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Attachment[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AuthenticatedDomain[]))]
	[JsonSerializable(typeof(StrongGrid.Models.AuthenticatedDomainDns[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BatchInfo[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BatchStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BccSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Block[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Bounce[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BouncePurgeSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BounceType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BrandedLink[]))]
	[JsonSerializable(typeof(StrongGrid.Models.BrandedLinkDns[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ClickTrackingSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ConditionOperator[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Contact[]))]
	[JsonSerializable(typeof(StrongGrid.Models.CustomFieldMetadata[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Design[]))]
	[JsonSerializable(typeof(StrongGrid.Models.DnsRecord[]))]
	[JsonSerializable(typeof(StrongGrid.Models.DomainValidation[]))]
	[JsonSerializable(typeof(StrongGrid.Models.DomainValidationResults[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EditorType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.BlockedEvent[]), TypeInfoPropertyName = "EmailActivitiesBlockedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.BounceEvent[]), TypeInfoPropertyName = "EmailActivitiesBounceEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.ClickEvent[]), TypeInfoPropertyName = "EmailActivitiesClickEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DeferredEvent[]), TypeInfoPropertyName = "EmailActivitiesDeferredEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DeliveredEvent[]), TypeInfoPropertyName = "EmailActivitiesDeliveredEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.DroppedEvent[]), TypeInfoPropertyName = "EmailActivitiesDroppedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.Event[]), TypeInfoPropertyName = "EmailActivitiesEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.GroupResubscribeEvent[]), TypeInfoPropertyName = "EmailActivitiesGroupResubscribeEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.GroupUnsubscribeEvent[]), TypeInfoPropertyName = "EmailActivitiesGroupUnsubscribeEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.OpenEvent[]), TypeInfoPropertyName = "EmailActivitiesOpenEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.ProcessedEvent[]), TypeInfoPropertyName = "EmailActivitiesProcessedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.SpamReportEvent[]), TypeInfoPropertyName = "EmailActivitiesSpamReportEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivities.UnsubscribeEvent[]), TypeInfoPropertyName = "EmailActivitiesUnsubscribeEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivityStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailAddressSetting[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailMessageActivity[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailMessageSummary[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationAdditionalChecks[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationChecks[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationDomainChecks[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationLocalPartChecks[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationResult[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationVerdict[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EnforcedTlsSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Error[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EventType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.EventWebhookSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportJob[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportJobStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Field[]))]
	[JsonSerializable(typeof(StrongGrid.Models.FieldMetadata[]))]
	[JsonSerializable(typeof(StrongGrid.Models.FieldType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.FileType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.FooterGlobalSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.FooterSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Frequency[]))]
	[JsonSerializable(typeof(StrongGrid.Models.GlobalSetting[]))]
	[JsonSerializable(typeof(StrongGrid.Models.GlobalSuppression[]))]
	[JsonSerializable(typeof(StrongGrid.Models.GoogleAnalyticsGlobalSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.GoogleAnalyticsSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJob[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJobRequest[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJobStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportResults[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.InboundParseWebhookSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.InvalidEmail[]))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddress[]))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddressesRemaining[]))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddressType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.IpPool[]))]
	[JsonSerializable(typeof(StrongGrid.Models.IpPoolAddress[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Campaign[]), TypeInfoPropertyName = "LegacyCampaignArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.CampaignStatus[]), TypeInfoPropertyName = "LegacyCampaignStatusArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Contact[]), TypeInfoPropertyName = "LegacyContactArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.CustomFieldMetadata[]), TypeInfoPropertyName = "LegacyCustomFieldMetadataArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Field[]), TypeInfoPropertyName = "LegacyFieldArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.FieldMetadata[]), TypeInfoPropertyName = "LegacyFieldMetadataArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.ImportResult[]), TypeInfoPropertyName = "LegacyImportResultArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.List[]), TypeInfoPropertyName = "LegacyListArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.LogicalOperator[]), TypeInfoPropertyName = "LegacyLogicalOperatorArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.SearchCondition[]), TypeInfoPropertyName = "LegacySearchConditionArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.Segment[]), TypeInfoPropertyName = "LegacySegmentArray")]
	[JsonSerializable(typeof(StrongGrid.Models.LinkValidation[]))]
	[JsonSerializable(typeof(StrongGrid.Models.LinkValidationResults[]))]
	[JsonSerializable(typeof(StrongGrid.Models.List[]))]
	[JsonSerializable(typeof(StrongGrid.Models.MailAddress[]))]
	[JsonSerializable(typeof(StrongGrid.Models.MailContent[]))]
	[JsonSerializable(typeof(StrongGrid.Models.MailPersonalization[]))]
	[JsonSerializable(typeof(StrongGrid.Models.MailPriority[]))]
	[JsonSerializable(typeof(StrongGrid.Models.MailSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.MonitorSettings[]))]
#pragma warning disable CS0618 // Type or member is obsolete
	[JsonSerializable(typeof(StrongGrid.Models.NewRelicSettings[]))]
#pragma warning restore CS0618 // Type or member is obsolete
	[JsonSerializable(typeof(StrongGrid.Models.OpenTrackingSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.PaginationMetadata[]))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryLanguageVersion[]))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryValidationStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryValidationStatusType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ReservedFieldMetadata[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDns[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDnsValidation[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ReverseDnsValidationResults[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Search.ContactsFilterField[]), TypeInfoPropertyName = "SearchContactsFilterFieldArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.EmailActivitiesFilterField[]), TypeInfoPropertyName = "SearchEmailActivitiesFilterFieldArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.FilterTable[]), TypeInfoPropertyName = "SearchFilterTableArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchComparisonOperator[]), TypeInfoPropertyName = "SearchSearchComparisonOperatorArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteria[]), TypeInfoPropertyName = "SearchSearchCriteriaArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaBetween[]), TypeInfoPropertyName = "SearchSearchCriteriaBetweenArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaContains[]), TypeInfoPropertyName = "SearchSearchCriteriaContainsArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaGreaterEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaGreaterEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaGreaterThan[]), TypeInfoPropertyName = "SearchSearchCriteriaGreaterThanArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaIn[]), TypeInfoPropertyName = "SearchSearchCriteriaInArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaIsNotNull[]), TypeInfoPropertyName = "SearchSearchCriteriaIsNotNullArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaIsNull[]), TypeInfoPropertyName = "SearchSearchCriteriaIsNullArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaLessEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaLessEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaLessThan[]), TypeInfoPropertyName = "SearchSearchCriteriaLessThanArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaLike[]), TypeInfoPropertyName = "SearchSearchCriteriaLikeArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotBetween[]), TypeInfoPropertyName = "SearchSearchCriteriaNotBetweenArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaNotEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotIn[]), TypeInfoPropertyName = "SearchSearchCriteriaNotInArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaNotLike[]), TypeInfoPropertyName = "SearchSearchCriteriaNotLikeArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArg[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgBetween[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgBetweenArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgGreaterEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgGreaterEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgGreaterThan[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgGreaterThanArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgIn[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgInArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgLessEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgLessEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgLessThan[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgLessThanArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgLike[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgLikeArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotBetween[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotBetweenArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotEqual[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotEqualArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotIn[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotInArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotLike[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotLikeArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNotNull[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNotNullArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchCriteriaUniqueArgNull[]), TypeInfoPropertyName = "SearchSearchCriteriaUniqueArgNullArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchLogicalOperator[]), TypeInfoPropertyName = "SearchSearchLogicalOperatorArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Segment[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SenderIdentity[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SenderReputation[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSend[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendEmailConfig[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendSendTo[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamCheckingSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamCheckSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SpamReport[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Stat[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Statistic[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SubscriptionSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SubscriptionTrackingSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Subuser[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Suppression[]))]
	[JsonSerializable(typeof(StrongGrid.Models.SuppressionGroup[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Teammate[]))]
	[JsonSerializable(typeof(StrongGrid.Models.TeammateInvitation[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Template[]))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateType[]))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateVersion[]))]
	[JsonSerializable(typeof(StrongGrid.Models.TrackingSettings[]))]
	[JsonSerializable(typeof(StrongGrid.Models.UnsubscribeOptions[]))]
	[JsonSerializable(typeof(StrongGrid.Models.UserCredits[]))]
	[JsonSerializable(typeof(StrongGrid.Models.UserProfile[]))]
	[JsonSerializable(typeof(StrongGrid.Models.ValidationResult[]))]
	[JsonSerializable(typeof(StrongGrid.Models.VerificationStatus[]))]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.BouncedEvent[]), TypeInfoPropertyName = "WebhooksBouncedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.ClickedEvent[]), TypeInfoPropertyName = "WebhooksClickedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeferredEvent[]), TypeInfoPropertyName = "WebhooksDeferredEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeliveredEvent[]), TypeInfoPropertyName = "WebhooksDeliveredEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DeliveryEvent[]), TypeInfoPropertyName = "WebhooksDeliveryEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.DroppedEvent[]), TypeInfoPropertyName = "WebhooksDroppedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.EngagementEvent[]), TypeInfoPropertyName = "WebhooksEngagementEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.Event[]), TypeInfoPropertyName = "WebhooksEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.GroupResubscribeEvent[]), TypeInfoPropertyName = "WebhooksGroupResubscribeEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.GroupUnsubscribeEvent[]), TypeInfoPropertyName = "WebhooksGroupUnsubscribeEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmail[]), TypeInfoPropertyName = "WebhooksInboundEmailArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmailAttachment[]), TypeInfoPropertyName = "WebhooksInboundEmailAttachmentArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.InboundEmailEnvelope[]), TypeInfoPropertyName = "WebhooksInboundEmailEnvelopeArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.IpPool[]), TypeInfoPropertyName = "WebhooksIpPoolArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.Newsletter[]), TypeInfoPropertyName = "WebhooksNewsletterArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.OpenedEvent[]), TypeInfoPropertyName = "WebhooksOpenedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.ProcessedEvent[]), TypeInfoPropertyName = "WebhooksProcessedEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.SpamReportEvent[]), TypeInfoPropertyName = "WebhooksSpamReportEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UnsubscribeEvent[]), TypeInfoPropertyName = "WebhooksUnsubscribeEventArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UrlOffset[]), TypeInfoPropertyName = "WebhooksUrlOffsetArray")]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UrlType[]), TypeInfoPropertyName = "WebhooksUrlTypeArray")]
	[JsonSerializable(typeof(StrongGrid.Models.WhitelistedIp[]))]

	[JsonSerializable(typeof(StrongGrid.Models.AggregateBy?))]
	[JsonSerializable(typeof(StrongGrid.Models.AlertType?))]
	[JsonSerializable(typeof(StrongGrid.Models.BatchStatus?))]
	[JsonSerializable(typeof(StrongGrid.Models.BounceType?))]
	[JsonSerializable(typeof(StrongGrid.Models.ConditionOperator?))]
	[JsonSerializable(typeof(StrongGrid.Models.EditorType?))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailActivityStatus?))]
	[JsonSerializable(typeof(StrongGrid.Models.EmailValidationVerdict?))]
	[JsonSerializable(typeof(StrongGrid.Models.EventType?))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportJobStatus?))]
	[JsonSerializable(typeof(StrongGrid.Models.ExportType?))]
	[JsonSerializable(typeof(StrongGrid.Models.FieldType?))]
	[JsonSerializable(typeof(StrongGrid.Models.FileType?))]
	[JsonSerializable(typeof(StrongGrid.Models.Frequency?))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportJobStatus?))]
	[JsonSerializable(typeof(StrongGrid.Models.ImportType?))]
	[JsonSerializable(typeof(StrongGrid.Models.IpAddressType?))]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.CampaignStatus?), TypeInfoPropertyName = "LegacyCampaignStatusNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.Legacy.LogicalOperator?), TypeInfoPropertyName = "LegacyLogicalOperatorNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.MailPriority?))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryLanguageVersion?))]
	[JsonSerializable(typeof(StrongGrid.Models.QueryValidationStatusType?))]
	[JsonSerializable(typeof(StrongGrid.Models.Search.ContactsFilterField?), TypeInfoPropertyName = "SearchContactsFilterFieldNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.EmailActivitiesFilterField?), TypeInfoPropertyName = "SearchEmailActivitiesFilterFieldNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.FilterTable?), TypeInfoPropertyName = "SearchFilterTableNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchComparisonOperator?), TypeInfoPropertyName = "SearchSearchComparisonOperatorNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.Search.SearchLogicalOperator?), TypeInfoPropertyName = "SearchSearchLogicalOperatorNullable")]
	[JsonSerializable(typeof(StrongGrid.Models.SingleSendStatus?))]
	[JsonSerializable(typeof(StrongGrid.Models.TemplateType?))]
	[JsonSerializable(typeof(StrongGrid.Models.Webhooks.UrlType?), TypeInfoPropertyName = "WebhooksUrlTypeNullable")]
	internal partial class StrongGridJsonSerializerContext : JsonSerializerContext
	{
	}
}
