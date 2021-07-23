class CardInitializer{
    constructor( ){
this._values =  ['6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A', ] 
this._suits = ['♥', '♦', '♣', '♠']
    }
    getCountCard () {
        return this._values.length * this._suits.length
    }
    checkIndex (index = 0) {
        if (typeof index === 'number') {
            if (index >= 0 && index < getCountCard()) {
                return true;
            }
        }
        return false;
    }
    getUnicCard = function (index) {
        if (checkIndex(index)) {
            return {
                value: _values[index % _values.length],
                suit: _suits[index % _suits.length],
                strength: 6 + index % _values.length
            }
        }
    }
}
class Card{
    constructor(_card, _isTrump){
        this._card = unicCard
        this._isTrump = false
    }
    getSuit () {
        return _card.getUnicCard(suit);
    }
    getStrength () {
        return _card.getUnicCard(strength);
    }
    getValue () {
        return _card.getUnicCard(value);
    }
    getTrumpStatus  () {
        return _isTrump;
    }
    changeTrump (status = false) {
        if (_isTrump == false && status == true) {
            _isTrump = true;
            _card.strength += 1000;
        }
        if (_isTrump == true && status == false) {
            _isTrump = false;
            _card.strength -= 1000;
        }
    }
    toString () {
        return "Suit: " + this.getSuit() + " Strength: " + this.getStrength() + " Value: " + this.getValue() + " isTrump: " + _isTrump;
    }
}
 class CardDeck{

     constructor(_cI,_cards, _currentTrumpSuit){
     this._cI = _cI
     this._cards = []
     this._currentTrumpSuit = null
    }
    setTrumpSuit() {
        _currentTrumpSuit = this._cards[Math.floor(Math.random() * this._cI.getCountCard())].getSuit();
        this._cards.forEach(function (item, index) {
            item.changeTrump(item.getSuit() == _currentTrumpSuit)
        })
    }
    shuffle(rV, temp) {
        //тасования Фишера-Йетса
        rV = 0
        temp = null
        for (var i = 0; i < _cards.length; i++) {
            rV = Math.floor(Math.random() * i)
            temp = _cards[i]
            _cards[i] = _cards[rV]
            _cards[rV] = temp
        }
    }
    getCountCard () {
        return this._cI.getCountCard()
    }
    getOneCard(index) {
        if (this._cI.checkIndex(index)) {
            return _cards[index]
        }
        return null
    }
    getCurrentTrumpSuit() {
        return _currentTrumpSuit
    }
    new () {
        for (let i = 0; i < this._cI.getCountCard(); i++) {
            _cards[i] = new Card(_cI.getUnicCard(i))
        }
    }
}


// var cd = new CardDeck();
// for (var i = 0; i < cd.getCountCard(); i++) {
//     console.log(cd.getOneCard(i).toString());
// }
