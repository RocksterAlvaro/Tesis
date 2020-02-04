:setvar BasePath "C:\Users\Rockster_Laptop\Desktop\Tesis\SQL_Scripts\"
:setvar Create "TesisDBCreate.sql"
:setvar SeedProducts "TesisDBSeedProducts.sql"
:setvar StoredProcedures "TesisDBStoredProcedures.sql"

:r $(BasePath)$(Create)
:r $(BasePath)$(StoredProcedures)
:r $(BasePath)$(SeedProducts)