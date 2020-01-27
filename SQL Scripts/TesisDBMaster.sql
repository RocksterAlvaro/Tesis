:setvar BasePath "C:\Users\Saito\Desktop\TesisNoire\TesisGit\SQL Scripts\"
:setvar Create "TesisDBCreate.sql"
:setvar SeedProducts "TesisDBSeedProducts.sql"
:setvar StoredProcedures "TesisDBStoredProcedures.sql"

:r $(BasePath)$(Create)
:r $(BasePath)$(StoredProcedures)
:r $(BasePath)$(SeedProducts)