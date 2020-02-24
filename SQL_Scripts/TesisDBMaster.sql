-- Nicolas
-- :setvar BasePath "C:\Users\Saito\Desktop\TesisNoire\TesisGit\SQL_Scripts\"

-- Alvaro
:setvar BasePath "C:\Users\Rockster_Laptop\Desktop\Tesis\SQL_Scripts\"
--:setvar BasePath "C:\Users\Rockster_Laptop\Downloads\Tesis\SQL_Scripts\"

:setvar Create "TesisDBCreate.sql"
:setvar SeedProducts "TesisDBSeedProducts.sql"
:setvar StoredProcedures "TesisDBStoredProcedures.sql"

:r $(BasePath)$(Create)
:r $(BasePath)$(StoredProcedures)
:r $(BasePath)$(SeedProducts)

-- Free cache
-- DBCC FREEPROCCACHE
-- DBCC DROPCLEANBUFFERS