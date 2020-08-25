function countOfMathExpressions(expression) {

    let NumberRegex = /[0-9]*[.,]?[0-9]+/g;
    expression = expression.split(' ').join('');

    let rowNumber = expression.match(NumberRegex);        
    arrayOfOperations = expression.replace(NumberRegex, '');

    let currentValue = Number(rowNumber[0]);

    for (var i = 0; i < arrayOfOperations.length; i++) {
        switch (arrayOfOperations[i]) {
            case '+':
                currentValue = currentValue + Number(rowNumber[i + 1]);
                break;
            case '-':
                currentValue = currentValue - Number(rowNumber[i + 1]);
                break;
            case '*':
                currentValue = currentValue * Number(rowNumber[i + 1]);
                break;
            case '/':
                currentValue = currentValue / Number(rowNumber[i + 1]);
                break;
            case '=':
                console.log(currentValue.toFixed(2));
                break;
        }
    }
}

let mathExpression = "3.5 +4*10-5.3/5 ="

console.log(countOfMathExpressions(mathExpression))

