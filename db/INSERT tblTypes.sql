USE atxtexme_db1
DELETE tc.tblImages
DELETE tc.tblItems
DELETE tc.tblTypes
GO
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Puppets', 'Puppets'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'WoodenToys', 'Wooden Toys'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Other', 'Various Other Toys'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Playmobile', 'Playmobile Kits'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Lego', 'Lego Kits'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Football', 'Football Toys'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Musical', 'Musical Items'
INSERT INTO tc.tblTypes(TypeName, TypeDescription) SELECT 'Figurines', 'Papo and Schleich Figurines'
