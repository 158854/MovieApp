SET IDENTITY_INSERT [dbo].[Directors] ON
INSERT INTO [dbo].[Directors] ([DirectorId], [FirstName], [LastName]) VALUES (1, 'James', 'Sue')
INSERT INTO [dbo].[Directors] ([DirectorId], [FirstName], [LastName]) VALUES (2, 'Ricky', 'Martin')
INSERT INTO [dbo].[Directors] ([DirectorId], [FirstName], [LastName]) VALUES (3, 'Eric', 'Pryc')
SET IDENTITY_INSERT [dbo].[Directors] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON
INSERT INTO [dbo].[Movies] ([MovieId], [Title], [Genre], [ReleaseYear], [DirectorId]) VALUES (1, 'Titanic', 'Tragedia', '1997', 1)
INSERT INTO [dbo].[Movies] ([MovieId], [Title], [Genre], [ReleaseYear], [DirectorId]) VALUES (2, 'Gladiator', 'Historyczny', '2001', 2)
INSERT INTO [dbo].[Movies] ([MovieId], [Title], [Genre], [ReleaseYear], [DirectorId]) VALUES (3, 'Hannibal', 'Akcja', '1999', 2)
INSERT INTO [dbo].[Movies] ([MovieId], [Title], [Genre], [ReleaseYear], [DirectorId]) VALUES (4, 'Pitbul', 'Akcja', '2002', 3)
INSERT INTO [dbo].[Movies] ([MovieId], [Title], [Genre], [ReleaseYear], [DirectorId]) VALUES (5, 'Król Lew', 'Animowany', '2019', 1)
INSERT INTO [dbo].[Movies] ([MovieId], [Title], [Genre], [ReleaseYear], [DirectorId]) VALUES (6, 'Aladdyn', 'Komedia', '2019', 1)
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[Reviews] ON
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (1, 'Taki o', 5, 1)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (2, 'Beznadziejny', 1, 1)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (3, 'Nie zachwyca', 3, 2)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (4, 'Nie mam zdania', 7, 3)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (5, 'Całkiem spoko', 8, 4)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (6, 'Ok', 8, 5)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (7, 'Bardzo fajny', 9, 6)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (8, 'Może być', 7, 6)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (9, 'Słaby', 1, 5)
INSERT INTO [dbo].[Reviews] ([ReviewId], [Comment], [Rate], [MovieId]) VALUES (10, 'Super film', 10, 5)
SET IDENTITY_INSERT [dbo].[Reviews] OFF