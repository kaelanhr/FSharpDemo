namespace NumberOperations

module Exponential =
    let Exponent (x:float, y:float) = x**y
    let SquareNumber (x:float) = Exponent (x, 2.0)
    let AddNumber x y = x + y
    let inline MultiplyNumber (x, y) = x * y
    let inline DivideNumber (x, y) = x / y
    let GetPercentage (fraction:float, total:float) = MultiplyNumber (DivideNumber (fraction, total), 100.0)
    let GetPercentageString (fraction:float, total:float) = (GetPercentage (fraction, total)).ToString() + "%"