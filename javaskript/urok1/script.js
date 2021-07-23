let CardInitializer = function() {
    let _values = ['6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
    let _suits = ['♥', '♦', '♣', '♠'];
    this.getUnicCard = function (index) {
        if (this.checkIndex(index)) {
            return {
                value: _values[index % _values.length],
                suit: _suits[index % _suits.length],
                strength: 6 + index % _values.length
            }
        }
    }

    this.getCountCard = function (index) {
        return _values.length * _suits.length;
    }

    this.checkIndex = function (index) {
        if (typeof index === 'number') {
            if (index >= 0 && index < this.getCountCard()) {
                return true;
            }
        }
        return false;
    }
}

let Card = function (unicCard) {
    let _card = unicCard;
    let _isTrump = false;
    this.getSuit = function () {
        return _card.suit;
    }

    this.getValue = function () {
        return _card.value;
    }

    this.getStrength = function () {
        return _card.strength;
    }

    this.getTrumpStatus = function () {
        return _isTrump;
    }

    this.changeTrump = function () {
        _isTrump = !_isTrump;
        if (_isTrump) _card.strength += 1000;
        else _card.strength -= 1000;
    }

    this.toString = function () {
        return "Suit: " + this.getSuit() + " Strength: " + this.getStrength() + " Value: " + this.getValue() + " isTrump: " + _isTrump;
    }
};
// --> Debug --> --> --> --> -->
let cI = new CardInitializer();
let cards = [];
for (let i = 0; i < cI.getCountCard(); i++) {
    cards[i] = new Card(cI.getUnicCard(i));
    if (i === 15)
        cards[i].changeTrump();
    console.log(cards[i].toString());
}


var CardDesk = function () {
    var _cI = new CardInitializer();
    var _cards = [];
    for (let i = 0; i < _cl.getCountCard(); i++) {
        _cards[i] = new Card(_cI.getUnicCard(i));
        
    }
    var _currentTrumpSuit = null;
    var setTrumpSuit = function(){
        _currentTrumpSuit = _cards[Math.floor(Math.random() *_cI.getCountCard())].getSuit();
        _cards.forEach(function(item,index)){
            item.changeTrump(item.getSuit() == _currentTrumpSuit);
        });
    }

    var shuffle = function(){

    }

    this.OneCard = function(){

    }

    this.currentTrumpSuit = function(){

    }

    this.new = function(){
for (let i = 0; i < _cI.getCountCard; i++) {
    _cards[i] = new Card(_cl.getUnicCard(i));
}
setTrumpSuit();
shuffle();
    
}
this.new();
    }