USE [EmegenlerTryDB]
GO
SET IDENTITY_INSERT [Emegenler].[EmegenlerPolicies] ON 

INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (2, 1, N'1', N'Component', N'.itsection', N'Show')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (3, 1, N'1', N'Component', N'.hrsection', N'Show')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (4, 1, N'2', N'Component', N'.itsection', N'Show')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (5, 1, N'3', N'Component', N'.hrsection', N'Show')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (6, 1, N'4', N'Component', N'.salessection', N'Show')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (7, 1, N'2', N'Page', N'permission/add/*', N'AccessGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (8, 1, N'2', N'Page', N'permission/edit/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (9, 1, N'2', N'Page', N'permission/delete/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (10, 1, N'3', N'Page', N'permission/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (11, 1, N'4', N'Page', N'permission/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (12, 1, N'2', N'Form', N'#ItReportForm', N'ActionGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (13, 1, N'2', N'Form', N'#SaleReportForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (14, 1, N'2', N'Form', N'#HrReportForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (15, 1, N'3', N'Form', N'#HrReportForm', N'ActionGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (16, 1, N'3', N'Form', N'#SaleReportForm', N'Hide')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (17, 1, N'3', N'Form', N'#SaleReportForm', N'Hide')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (18, 1, N'4', N'Form', N'#SaleReportForm', N'ActionGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (19, 1, N'4', N'Form', N'#ItReportForm', N'Hide')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (20, 1, N'4', N'Form', N'#HrReportForm', N'Hide')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (21, 1, N'1', N'Form', N'#SaleReportForm', N'ActionGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (22, 1, N'1', N'Form', N'#ItReportForm', N'ActionGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (23, 1, N'1', N'Form', N'#HrReportForm', N'ActionGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (24, 1, N'2', N'Page', N'form/itlist/*', N'AccessGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (25, 1, N'2', N'Page', N'form/hrlist/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (26, 1, N'2', N'Page', N'form/salelist/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (27, 1, N'3', N'Page', N'form/itlist/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (28, 1, N'3', N'Page', N'form/hrlist/*', N'AccessGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (29, 1, N'3', N'Page', N'form/salelist/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (30, 1, N'4', N'Page', N'form/itlist/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (31, 1, N'4', N'Page', N'form/hrlist/*', N'AccessDenied')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (32, 1, N'4', N'Page', N'form/salelist/*', N'AccessGranted')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (33, 1, N'2', N'Link', N'#ListHrForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (34, 1, N'2', N'Link', N'#ListSalesForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (35, 1, N'3', N'Link', N'#ListItForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (36, 1, N'3', N'Link', N'#ListSalesForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (37, 1, N'4', N'Link', N'#ListHrForm', N'Readonly')
INSERT [Emegenler].[EmegenlerPolicies] ([PolicyId], [AuthBase], [AuthBaseIdentifier], [PolicyElement], [PolicyElementIdentifier], [AccessProtocol]) VALUES (38, 1, N'4', N'Link', N'#ListItForm', N'Readonly')
SET IDENTITY_INSERT [Emegenler].[EmegenlerPolicies] OFF
