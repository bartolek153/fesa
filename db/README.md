# Banco de Dados II

## Views

```sql
CREATE [ OR ALTER ] VIEW [ schema_name . ] view_name [ (column [ ,...n ] ) ]
[ WITH <view_attribute> [ ,...n ] ]
AS select_statement
[ WITH CHECK OPTION ]
[ ; ]  
  
<view_attribute> ::=
{  
    [ ENCRYPTION ]  
    [ SCHEMABINDING ]  
    [ VIEW_METADATA ]
}
```

Uma `View` é uma tabela virtual baseada no resultado de uma consulta (SELECT) a uma ou mais tabelas, que contém linhas e colunas, como uma tabela real.

A tabela virtual é uma tabela que não existe fisicamente, mas que é gerada por meio de uma instrução SQL.

As `Views` são armazenadas no banco de dados como objetos nomeados.

```sql
-- cria (ou altera se o nome já existe)
CREATE OR ALTER VIEW [Current Product List] AS
    SELECT ProductID, ProductName
    FROM Products
    WHERE Discontinued = 0  -- ainda em "produção"

-- consulta
SELECT * FROM "Current Product List"

-- remove
DROP VIEW "Current Product List"
```

Você pode também criar `Views` com `Views` existentes e com outras `Views` complexas.

```sql
-- Pedidos com detalhes
CREATE VIEW "Order Details Extended" AS
    SELECT 
        "Order Details".OrderID, 
        "Order Details".ProductID, 
        Products.ProductName, 
        "Order Details".UnitPrice, 
        "Order Details".Quantity, 
        "Order Details".Discount, 
    FROM 
        Products 
    INNER JOIN 
        "Order Details" ON Products.ProductID = "Order Details".ProductID

-- Vendas por categoria, baseado na view anterior
CREATE VIEW "Sales by Category" AS
    SELECT 
        Categories.CategoryID, 
        Categories.CategoryName, 
        Products.ProductName, 
        Sum("Order Details Extended".ExtendedPrice) AS ProductSales
    FROM Categories 
    INNER JOIN Products ON Categories.CategoryID = Products.CategoryID
    INNER JOIN "Order Details Extended" ON Products.ProductID = "Order Details Extended".ProductID
    INNER JOIN Orders ON Orders.OrderID = "Order Details Extended".OrderID
    WHERE Orders.OrderDate BETWEEN '19970101' And '19971231'
    GROUP BY 
        Categories.CategoryID, 
        Categories.CategoryName, 
        Products.ProductName
```

## Tabelas Temporárias

As `Tabelas Temporárias` são um recurso que permite criar uma tabela que existe apenas durante a sessão atual de um usuário. Essas tabelas são armazenadas em disco, mas são automaticamente descartadas quando a conexão é encerrada.

* Locais (`#table`): são visíveis apenas para a conexão de banco de dados atual
* Global (`##table`): são visíveis para todas as conexões de banco de dados no mesmo servidor

```sql
-- Usando SELECT INTO
SELECT 
    select_list
INTO 
    temporary_table
FROM 
    table_name

-- Usando CREATE TABLE
CREATE TABLE #temporary_table (
    column_list
)
```

## Stored Procedures

As `Stored Procedures` são um conjunto de instruções SQL que são armazenadas no banco de dados como um objeto nomeado. Essas instruções são executadas sempre que o nome da `Stored Procedure` é chamado.

```sql
```

## Triggers

```sql
```

## Funções

```sql
```

## Transações

```sql
```

## Cursor

```sql
```

## Índices

```sql
```

## Import Databases (SQL Server)

```sql
```
