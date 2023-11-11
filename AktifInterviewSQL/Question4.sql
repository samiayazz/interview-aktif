CREATE TABLE Orders (
  OrderID INT IDENTITY(1,1) PRIMARY KEY
  )
  
  CREATE TABLE OrderDetails (
  OrderDetailID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT FOREIGN KEY(OrderID) REFERENCES Orders(OrderID)
  )

SELECT od.OrderID FROM OrderDetails od JOIN Orders o ON od.OrderID = o.orderid
GROUP BY od.OrderID HAVING count(od.OrderID) > 3