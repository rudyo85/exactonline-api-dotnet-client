' Last generated on 2017-11-07 10:05:59Z

Public Class [Services]
	Public Services As Dictionary(Of String, String) = New Dictionary(Of String, String)

	Public Sub New()
		Services.Add(GetType(Accountancy.AccountInvolvedAccount).FullName, "Accountancy/AccountInvolvedAccounts")
		Services.Add(GetType(Accountancy.AccountOwner).FullName, "Accountancy/AccountOwners")
		Services.Add(GetType(Accountancy.InvolvedUser).FullName, "Accountancy/InvolvedUsers")
		Services.Add(GetType(Accountancy.InvolvedUserRole).FullName, "Accountancy/InvolvedUserRoles")
		Services.Add(GetType(Accountancy.SolutionLink).FullName, "Accountancy/SolutionLinks")
		Services.Add(GetType(Accountancy.TaskType).FullName, "Accountancy/TaskTypes")
		Services.Add(GetType(Activities.CommunicationNote).FullName, "Activities/CommunicationNotes")
		Services.Add(GetType(Activities.Complaint).FullName, "Activities/Complaints")
		Services.Add(GetType(Activities.Event).FullName, "Activities/Events")
		Services.Add(GetType(Activities.ServiceRequest).FullName, "Activities/ServiceRequests")
		Services.Add(GetType(Activities.Task).FullName, "Activities/Tasks")
		Services.Add(GetType(Assets.Asset).FullName, "Assets/Assets")
		Services.Add(GetType(Assets.AssetGroup).FullName, "Assets/AssetGroups")
		Services.Add(GetType(Assets.DepreciationMethod).FullName, "Assets/DepreciationMethods")
		Services.Add(GetType(Budget.Budget).FullName, "Budget/Budgets")
		Services.Add(GetType(Bulk.Document).FullName, "Bulk/Documents/Documents")
		Services.Add(GetType(Bulk.DocumentAttachment).FullName, "Bulk/Documents/DocumentAttachments")
		Services.Add(GetType(Bulk.FinancialTransactionLine).FullName, "Bulk/Financial/TransactionLines")
		Services.Add(GetType(Cashflow.Bank).FullName, "Cashflow/Banks")
		Services.Add(GetType(Cashflow.DirectDebitMandate).FullName, "Cashflow/DirectDebitMandates")
		Services.Add(GetType(Cashflow.Payment).FullName, "Cashflow/Payments")
		Services.Add(GetType(Cashflow.PaymentCondition).FullName, "Cashflow/PaymentConditions")
		Services.Add(GetType(Cashflow.PaymentID).FullName, "Cashflow/PaymentIDs")
		Services.Add(GetType(Cashflow.ProcessPayment).FullName, "Cashflow/ProcessPayments")
		Services.Add(GetType(Cashflow.Receivable).FullName, "Cashflow/Receivables")
		Services.Add(GetType(CRM.AcceptQuotation).FullName, "CRM/AcceptQuotation")
		Services.Add(GetType(CRM.Account).FullName, "CRM/Accounts")
		Services.Add(GetType(CRM.AccountClass).FullName, "CRM/AccountClasses")
		Services.Add(GetType(CRM.AccountClassification).FullName, "CRM/AccountClassifications")
		Services.Add(GetType(CRM.AccountClassificationName).FullName, "CRM/AccountClassificationNames")
		Services.Add(GetType(CRM.Address).FullName, "CRM/Addresses")
		Services.Add(GetType(CRM.AddressState).FullName, "CRM/AddressStates")
		Services.Add(GetType(CRM.BankAccount).FullName, "CRM/BankAccounts")
		Services.Add(GetType(CRM.Contact).FullName, "CRM/Contacts")
		Services.Add(GetType(CRM.Document).FullName, "Read/CRM/Documents")
		Services.Add(GetType(CRM.DocumentsAttachment).FullName, "Read/CRM/DocumentsAttachments")
		Services.Add(GetType(CRM.Opportunity).FullName, "CRM/Opportunities")
		Services.Add(GetType(CRM.OpportunityContact).FullName, "Read/CRM/OpportunityContacts")
		Services.Add(GetType(CRM.PrintQuotation).FullName, "CRM/PrintQuotation")
		Services.Add(GetType(CRM.Quotation).FullName, "CRM/Quotations")
		Services.Add(GetType(CRM.QuotationLine).FullName, "CRM/QuotationLines")
		Services.Add(GetType(CRM.ReasonCode).FullName, "CRM/ReasonCodes")
		Services.Add(GetType(CRM.RejectQuotation).FullName, "CRM/RejectQuotation")
		Services.Add(GetType(CRM.ReopenQuotation).FullName, "CRM/ReopenQuotation")
		Services.Add(GetType(CRM.ReviewQuotation).FullName, "CRM/ReviewQuotation")
		Services.Add(GetType(Current.Me).FullName, "Current/Me")
		Services.Add(GetType(Documents.Document).FullName, "Documents/Documents")
		Services.Add(GetType(Documents.DocumentAttachment).FullName, "Documents/DocumentAttachments")
		Services.Add(GetType(Documents.DocumentCategory).FullName, "Documents/DocumentCategories")
		Services.Add(GetType(Documents.DocumentFolder).FullName, "Documents/DocumentFolders")
		Services.Add(GetType(Documents.DocumentType).FullName, "Documents/DocumentTypes")
		Services.Add(GetType(Documents.DocumentTypeCategory).FullName, "Documents/DocumentTypeCategories")
		Services.Add(GetType(Documents.DocumentTypeFolder).FullName, "Documents/DocumentTypeFolders")
		Services.Add(GetType(Financial.AgingOverview).FullName, "Read/Financial/AgingOverview")
		Services.Add(GetType(Financial.AgingPayablesList).FullName, "Read/Financial/AgingPayablesList")
		Services.Add(GetType(Financial.AgingReceivablesList).FullName, "Read/Financial/AgingReceivablesList")
		Services.Add(GetType(Financial.ExchangeRate).FullName, "Financial/ExchangeRates")
		Services.Add(GetType(Financial.FinancialPeriod).FullName, "Financial/FinancialPeriods")
		Services.Add(GetType(Financial.GLAccount).FullName, "Financial/GLAccounts")
		Services.Add(GetType(Financial.GLClassification).FullName, "Financial/GLClassifications")
		Services.Add(GetType(Financial.GLScheme).FullName, "Financial/GLSchemes")
		Services.Add(GetType(Financial.GLTransactionType).FullName, "Financial/GLTransactionTypes")
		Services.Add(GetType(Financial.Journal).FullName, "Financial/Journals")
		Services.Add(GetType(Financial.JournalStatusList).FullName, "Read/Financial/JournalStatusList")
		Services.Add(GetType(Financial.OutstandingInvoicesOverview).FullName, "Read/Financial/OutstandingInvoicesOverview")
		Services.Add(GetType(Financial.PayablesList).FullName, "Read/Financial/PayablesList")
		Services.Add(GetType(Financial.ProfitLossOverview).FullName, "Read/Financial/ProfitLossOverview")
		Services.Add(GetType(Financial.ReceivablesList).FullName, "Read/Financial/ReceivablesList")
		Services.Add(GetType(Financial.ReportingBalance).FullName, "Financial/ReportingBalance")
		Services.Add(GetType(Financial.Return).FullName, "Read/Financial/Returns")
		Services.Add(GetType(Financial.RevenueList).FullName, "Read/Financial/RevenueList")
		Services.Add(GetType(FinancialTransaction.BankEntry).FullName, "FinancialTransaction/BankEntries")
		Services.Add(GetType(FinancialTransaction.BankEntryLine).FullName, "FinancialTransaction/BankEntryLines")
		Services.Add(GetType(FinancialTransaction.CashEntry).FullName, "FinancialTransaction/CashEntries")
		Services.Add(GetType(FinancialTransaction.CashEntryLine).FullName, "FinancialTransaction/CashEntryLines")
		Services.Add(GetType(FinancialTransaction.Transaction).FullName, "FinancialTransaction/Transactions")
		Services.Add(GetType(FinancialTransaction.TransactionLine).FullName, "FinancialTransaction/TransactionLines")
		Services.Add(GetType(General.Currency).FullName, "General/Currencies")
		Services.Add(GetType(GeneralJournalEntry.GeneralJournalEntry).FullName, "GeneralJournalEntry/GeneralJournalEntries")
		Services.Add(GetType(GeneralJournalEntry.GeneralJournalEntryLine).FullName, "GeneralJournalEntry/GeneralJournalEntryLines")
		Services.Add(GetType(HRM.AbsenceRegistration).FullName, "HRM/AbsenceRegistrations")
		Services.Add(GetType(HRM.AbsenceRegistrationTransaction).FullName, "HRM/AbsenceRegistrationTransactions")
		Services.Add(GetType(HRM.Costcenter).FullName, "HRM/Costcenters")
		Services.Add(GetType(HRM.Costunit).FullName, "HRM/Costunits")
		Services.Add(GetType(HRM.Department).FullName, "HRM/Departments")
		Services.Add(GetType(HRM.Division).FullName, "HRM/Divisions")
		Services.Add(GetType(HRM.DivisionClass).FullName, "HRM/DivisionClasses")
		Services.Add(GetType(HRM.DivisionClassName).FullName, "HRM/DivisionClassNames")
		Services.Add(GetType(HRM.DivisionClassValue).FullName, "HRM/DivisionClassValues")
		Services.Add(GetType(HRM.JobGroup).FullName, "HRM/JobGroups")
		Services.Add(GetType(HRM.JobTitle).FullName, "HRM/JobTitles")
		Services.Add(GetType(HRM.LeaveBuildUpRegistration).FullName, "HRM/LeaveBuildUpRegistrations")
		Services.Add(GetType(HRM.LeaveRegistration).FullName, "HRM/LeaveRegistrations")
		Services.Add(GetType(HRM.Schedule).FullName, "HRM/Schedules")
		Services.Add(GetType(Inventory.AssemblyOrder).FullName, "Inventory/AssemblyOrders")
		Services.Add(GetType(Inventory.BatchNumber).FullName, "Inventory/BatchNumbers")
		Services.Add(GetType(Inventory.BatchQuantitiesPerLocation).FullName, "")
		Services.Add(GetType(Inventory.BatchQuantitiesPerWarehouse).FullName, "")
		Services.Add(GetType(Inventory.ItemWarehous).FullName, "Inventory/ItemWarehouses")
		Services.Add(GetType(Inventory.ItemWarehousePlanningDetail).FullName, "Inventory/ItemWarehousePlanningDetails")
		Services.Add(GetType(Inventory.ItemWarehouseStorageLocation).FullName, "Inventory/ItemWarehouseStorageLocations")
		Services.Add(GetType(Inventory.ProcessStockCount).FullName, "Inventory/ProcessStockCount")
		Services.Add(GetType(Inventory.SerialNumber).FullName, "Inventory/SerialNumbers")
		Services.Add(GetType(Inventory.StockBatchNumber).FullName, "Inventory/StockBatchNumbers")
		Services.Add(GetType(Inventory.StockCount).FullName, "Inventory/StockCounts")
		Services.Add(GetType(Inventory.StockCountLine).FullName, "Inventory/StockCountLines")
		Services.Add(GetType(Inventory.StockSerialNumber).FullName, "Inventory/StockSerialNumbers")
		Services.Add(GetType(Inventory.StorageLocation).FullName, "Inventory/StorageLocations")
		Services.Add(GetType(Inventory.Warehouse).FullName, "Inventory/Warehouses")
		Services.Add(GetType(Logistics.Item).FullName, "Logistics/Items")
		Services.Add(GetType(Logistics.ItemGroup).FullName, "Logistics/ItemGroups")
		Services.Add(GetType(Logistics.ItemVersion).FullName, "Logistics/ItemVersions")
		Services.Add(GetType(Logistics.SalesItemPrice).FullName, "Logistics/SalesItemPrices")
		Services.Add(GetType(Logistics.SupplierItem).FullName, "Logistics/SupplierItem")
		Services.Add(GetType(Logistics.Unit).FullName, "Logistics/Units")
		Services.Add(GetType(Mailbox.DefaultMailbox).FullName, "Read/Mailbox/DefaultMailbox")
		Services.Add(GetType(Mailbox.Mailbox).FullName, "Mailbox/Mailboxes")
		Services.Add(GetType(Mailbox.MailMessageAttachment).FullName, "Mailbox/MailMessageAttachments")
		Services.Add(GetType(Mailbox.MailMessagesReceived).FullName, "Mailbox/MailMessagesReceived")
		Services.Add(GetType(Mailbox.MailMessagesSent).FullName, "Mailbox/MailMessagesSent")
		Services.Add(GetType(Mailbox.PreferredMailbox).FullName, "Read/Mailbox/PreferredMailbox")
		Services.Add(GetType(Manufacturing.BillOfMaterialMaterial).FullName, "Manufacturing/BillOfMaterialMaterials")
		Services.Add(GetType(Manufacturing.BillOfMaterialVersion).FullName, "Manufacturing/BillOfMaterialVersions")
		Services.Add(GetType(Manufacturing.ByProductReceipt).FullName, "Manufacturing/ByProductReceipts")
		Services.Add(GetType(Manufacturing.ByProductReversal).FullName, "Manufacturing/ByProductReversals")
		Services.Add(GetType(Manufacturing.MaterialIssue).FullName, "Manufacturing/MaterialIssues")
		Services.Add(GetType(Manufacturing.MaterialReversal).FullName, "Manufacturing/MaterialReversals")
		Services.Add(GetType(Manufacturing.Operation).FullName, "Manufacturing/Operations")
		Services.Add(GetType(Manufacturing.OperationResource).FullName, "Manufacturing/OperationResources")
		Services.Add(GetType(Manufacturing.ProductionArea).FullName, "Manufacturing/ProductionAreas")
		Services.Add(GetType(Manufacturing.ShopOrder).FullName, "Manufacturing/ShopOrders")
		Services.Add(GetType(Manufacturing.ShopOrderMaterialPlan).FullName, "Manufacturing/ShopOrderMaterialPlans")
		Services.Add(GetType(Manufacturing.ShopOrderReceipt).FullName, "Manufacturing/ShopOrderReceipts")
		Services.Add(GetType(Manufacturing.ShopOrderReversal).FullName, "Manufacturing/ShopOrderReversals")
		Services.Add(GetType(Manufacturing.ShopOrderRoutingStepPlan).FullName, "Manufacturing/ShopOrderRoutingStepPlans")
		Services.Add(GetType(Manufacturing.StageForDeliveryReceipt).FullName, "Manufacturing/StageForDeliveryReceipts")
		Services.Add(GetType(Manufacturing.StageForDeliveryReversal).FullName, "Manufacturing/StageForDeliveryReversals")
		Services.Add(GetType(Manufacturing.SubOrderReceipt).FullName, "Manufacturing/SubOrderReceipts")
		Services.Add(GetType(Manufacturing.SubOrderReversal).FullName, "Manufacturing/SubOrderReversals")
		Services.Add(GetType(Manufacturing.TimeTransaction).FullName, "Manufacturing/TimeTransactions")
		Services.Add(GetType(Manufacturing.Workcenter).FullName, "Manufacturing/Workcenters")
		Services.Add(GetType(OpeningBalance.OpeningBalanceAfterEntry).FullName, "OpeningBalance/CurrentYear/AfterEntry")
		Services.Add(GetType(OpeningBalance.OpeningBalancePreviousYearAfterEntry).FullName, "OpeningBalance/PreviousYear/AfterEntry")
		Services.Add(GetType(OpeningBalance.OpeningBalancePreviousYearProcessed).FullName, "OpeningBalance/PreviousYear/Processed")
		Services.Add(GetType(OpeningBalance.OpeningBalanceProcessed).FullName, "OpeningBalance/CurrentYear/Processed")
		Services.Add(GetType(Payroll.ActiveEmployment).FullName, "Payroll/ActiveEmployments")
		Services.Add(GetType(Payroll.Employee).FullName, "Payroll/Employees")
		Services.Add(GetType(Payroll.Employment).FullName, "Payroll/Employments")
		Services.Add(GetType(Payroll.EmploymentContract).FullName, "Payroll/EmploymentContracts")
		Services.Add(GetType(Payroll.EmploymentContractFlexPhas).FullName, "Payroll/EmploymentContractFlexPhases")
		Services.Add(GetType(Payroll.EmploymentEndReason).FullName, "Payroll/EmploymentEndReasons")
		Services.Add(GetType(Payroll.EmploymentOrganization).FullName, "Payroll/EmploymentOrganizations")
		Services.Add(GetType(Payroll.EmploymentSalary).FullName, "Payroll/EmploymentSalaries")
		Services.Add(GetType(Payroll.TaxEmploymentEndFlexCode).FullName, "Payroll/TaxEmploymentEndFlexCodes")
		Services.Add(GetType(Project.CostTransaction).FullName, "Project/CostTransactions")
		Services.Add(GetType(Project.HourCostType).FullName, "Read/Project/HourCostTypes")
		Services.Add(GetType(Project.InvoiceTerm).FullName, "Project/InvoiceTerms")
		Services.Add(GetType(Project.Project).FullName, "Project/Projects")
		Services.Add(GetType(Project.ProjectBudgetType).FullName, "Project/ProjectBudgetTypes")
		Services.Add(GetType(Project.ProjectHourBudget).FullName, "Project/ProjectHourBudgets")
		Services.Add(GetType(Project.ProjectPlanning).FullName, "Project/ProjectPlanning")
		Services.Add(GetType(Project.ProjectPlanningRecurring).FullName, "Project/ProjectPlanningRecurring")
		Services.Add(GetType(Project.ProjectRestrictionEmployee).FullName, "Project/ProjectRestrictionEmployees")
		Services.Add(GetType(Project.ProjectRestrictionItem).FullName, "Project/ProjectRestrictionItems")
		Services.Add(GetType(Project.ProjectRestrictionRebilling).FullName, "Project/ProjectRestrictionRebillings")
		Services.Add(GetType(Project.RecentCost).FullName, "Read/Project/RecentCosts")
		Services.Add(GetType(Project.RecentHour).FullName, "Read/Project/RecentHours")
		Services.Add(GetType(Project.TimeAndBillingAccountDetail).FullName, "Read/Project/TimeAndBillingAccountDetails")
		Services.Add(GetType(Project.TimeAndBillingActivitiesAndExpens).FullName, "Read/Project/TimeAndBillingActivitiesAndExpenses")
		Services.Add(GetType(Project.TimeAndBillingEntryAccount).FullName, "Read/Project/TimeAndBillingEntryAccounts")
		Services.Add(GetType(Project.TimeAndBillingEntryProject).FullName, "Read/Project/TimeAndBillingEntryProjects")
		Services.Add(GetType(Project.TimeAndBillingEntryRecentAccount).FullName, "Read/Project/TimeAndBillingEntryRecentAccounts")
		Services.Add(GetType(Project.TimeAndBillingEntryRecentActivitiesAndExpens).FullName, "Read/Project/TimeAndBillingEntryRecentActivitiesAndExpenses")
		Services.Add(GetType(Project.TimeAndBillingEntryRecentHourCostType).FullName, "Read/Project/TimeAndBillingEntryRecentHourCostTypes")
		Services.Add(GetType(Project.TimeAndBillingEntryRecentProject).FullName, "Read/Project/TimeAndBillingEntryRecentProjects")
		Services.Add(GetType(Project.TimeAndBillingItemDetail).FullName, "Read/Project/TimeAndBillingItemDetails")
		Services.Add(GetType(Project.TimeAndBillingProjectDetail).FullName, "Read/Project/TimeAndBillingProjectDetails")
		Services.Add(GetType(Project.TimeCorrection).FullName, "Project/TimeCorrections")
		Services.Add(GetType(Project.TimeTransaction).FullName, "Project/TimeTransactions")
		Services.Add(GetType(Purchase.PurchaseInvoice).FullName, "Purchase/PurchaseInvoices")
		Services.Add(GetType(Purchase.PurchaseInvoiceLine).FullName, "Purchase/PurchaseInvoiceLines")
		Services.Add(GetType(PurchaseEntry.PurchaseEntry).FullName, "PurchaseEntry/PurchaseEntries")
		Services.Add(GetType(PurchaseEntry.PurchaseEntryLine).FullName, "PurchaseEntry/PurchaseEntryLines")
		Services.Add(GetType(PurchaseOrder.GoodsReceipt).FullName, "PurchaseOrder/GoodsReceipts")
		Services.Add(GetType(PurchaseOrder.GoodsReceiptLine).FullName, "PurchaseOrder/GoodsReceiptLines")
		Services.Add(GetType(PurchaseOrder.PurchaseOrder).FullName, "PurchaseOrder/PurchaseOrders")
		Services.Add(GetType(PurchaseOrder.PurchaseOrderLine).FullName, "PurchaseOrder/PurchaseOrderLines")
		Services.Add(GetType(Sales.PriceList).FullName, "Sales/PriceLists")
		Services.Add(GetType(Sales.SalesPriceListDetail).FullName, "Sales/SalesPriceListDetails")
		Services.Add(GetType(Sales.ShippingMethod).FullName, "Sales/ShippingMethods")
		Services.Add(GetType(SalesEntry.SalesEntry).FullName, "SalesEntry/SalesEntries")
		Services.Add(GetType(SalesEntry.SalesEntryLine).FullName, "SalesEntry/SalesEntryLines")
		Services.Add(GetType(SalesInvoice.InvoiceSalesOrder).FullName, "SalesInvoice/InvoiceSalesOrders")
		Services.Add(GetType(SalesInvoice.Layout).FullName, "SalesInvoice/Layouts")
		Services.Add(GetType(SalesInvoice.PrintedSalesInvoice).FullName, "SalesInvoice/PrintedSalesInvoices")
		Services.Add(GetType(SalesInvoice.SalesInvoice).FullName, "SalesInvoice/SalesInvoices")
		Services.Add(GetType(SalesInvoice.SalesInvoiceLine).FullName, "SalesInvoice/SalesInvoiceLines")
		Services.Add(GetType(SalesInvoice.SalesOrderID).FullName, "SalesInvoice/SalesOrderID")
		Services.Add(GetType(SalesOrder.GoodsDelivery).FullName, "SalesOrder/GoodsDeliveries")
		Services.Add(GetType(SalesOrder.GoodsDeliveryLine).FullName, "SalesOrder/GoodsDeliveryLines")
		Services.Add(GetType(SalesOrder.PrintedSalesOrder).FullName, "SalesOrder/PrintedSalesOrders")
		Services.Add(GetType(SalesOrder.SalesOrder).FullName, "SalesOrder/SalesOrders")
		Services.Add(GetType(SalesOrder.SalesOrderLine).FullName, "SalesOrder/SalesOrderLines")
		Services.Add(GetType(Subscription.Subscription).FullName, "Subscription/Subscriptions")
		Services.Add(GetType(Subscription.SubscriptionLine).FullName, "Subscription/SubscriptionLines")
		Services.Add(GetType(Subscription.SubscriptionLineType).FullName, "Subscription/SubscriptionLineTypes")
		Services.Add(GetType(Subscription.SubscriptionReasonCode).FullName, "Subscription/SubscriptionReasonCodes")
		Services.Add(GetType(Subscription.SubscriptionRestrictionEmployee).FullName, "Subscription/SubscriptionRestrictionEmployees")
		Services.Add(GetType(Subscription.SubscriptionRestrictionItem).FullName, "Subscription/SubscriptionRestrictionItems")
		Services.Add(GetType(Subscription.SubscriptionType).FullName, "Subscription/SubscriptionTypes")
		Services.Add(GetType(System.AccountantInfo).FullName, "System/AccountantInfo")
		Services.Add(GetType(System.AvailableFeature).FullName, "System/AvailableFeatures")
		Services.Add(GetType(System.Division).FullName, "System/Divisions")
		Services.Add(GetType(Users.User).FullName, "Users/Users")
		Services.Add(GetType(Users.UserRole).FullName, "Users/UserRoles")
		Services.Add(GetType(Users.UserRolesPerDivision).FullName, "Users/UserRolesPerDivision")
		Services.Add(GetType(VAT.VATCode).FullName, "VAT/VATCodes")
		Services.Add(GetType(VAT.VatPercentage).FullName, "VAT/VatPercentages")
		Services.Add(GetType(Workflow.RequestAttachment).FullName, "Workflow/RequestAttachments")

	End Sub
End Class
