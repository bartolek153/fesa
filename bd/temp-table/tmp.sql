-- Tabela temporária
-- Criação
CREATE TABLE #tempTable (
	id INT PRIMARY KEY,
	desc VARCHAR(30)
)

-- Inserir dados
INSERT INTO #tempTable VALUES (1, 'Control'), (2, 'Testing')

-- Cópia de tabela existente
SELECT * INTO #tempTable FROM Employees -- Copia a tabela employees

-- Remover coluna
ALTER TABLE #tempTable DROP COLUMN name

-- Adicionar coluna
ALTER TABLE #tempTable ADD name NVARCHAR(50) -- obs: nvarchar é varchar com unicode

-- Modificar coluna
ALTER TABLE #tempTable ALTER COLUMN name NVARCHAR(100)

-- Renomear
ALTER TABLE #tempTable RENAME COLUMN name person_name
