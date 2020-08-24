let someString = "У попа была собака"

function castToTrueArray(rows){
    let separators = [',', '.', '!', '?', '\t', ' ']
    let splitRows = rows.split(separators).join('')
    return splitRows.split(' ')
}

function findRepeatingSymbols(word, repeatingSymbols) {
    let str = word.toLowerCase()
    for (let i = 0; i < word.length; i++) {
        if (str.lastIndexOf(str[i]) != i && !repeatingSymbols.includes(str[i])) {
            repeatingSymbols.push(str[i]);
        }
    }
}

function charRemover(phrase) {
    let repeatingSymbols = [];
    let words = castToTrueArray(phrase);
    for (let i = 0; i < words.length; i++) {
        findRepeatingSymbols(words[i], repeatingSymbols);
    }
    for (let i = 0; i < repeatingSymbols.length; i++) {
        phrase = phrase.split(repeatingSymbols[i]).join('');
        phrase = phrase.split(repeatingSymbols[i].toUpperCase()).join('');
    }
    return phrase;
}

phrase = charRemover(someString);
console.log(phrase);