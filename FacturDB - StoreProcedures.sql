--STORE PROCEDURE LISTAR PARA PRODUCTS

CREATE PROCEDURE sp_GetProducts
AS
BEGIN
	SELECT product_id, name, price, stock, active from products;
END;


--STORE PROCEDURE INSERT PARA PRODUCTS

CREATE PROCEDURE sp_InsertProducto
	@name NVARCHAR(255),
	@price DECIMAL(10,2),
	@stock INT,
	@active BIT
AS
BEGIN
	DECLARE @nuevoId INT;
    -- Obtener el próximo valor para la clave primaria
    SELECT @nuevoId = ISNULL(MAX(product_id), 0) + 1 FROM products;

	INSERT INTO products (product_id,name, price, stock, active)
	VALUES(@nuevoId, @name, @price, @stock, @active);
END;


-- STORE PROCEDURE UPDATE PARA PRODUCTS

CREATE PROCEDURE sp_UpdateProduct
	@idproducto INT,
	@name NVARCHAR(255),
	@price DECIMAL(10,2),
	@stock INT,
	@active BIT
AS
BEGIN
	UPDATE products
	SET
	name = @name,
	price = @price,
	stock = @stock,
	active = @active
	WHERE
	product_id = @idproducto;
END;