var CardInitializer = function () {
    var _values = ['6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A', ];
    var _suits = ['♥', '♦', '♣', '♠'];
    this.getCountCard = function () {
        return _values.length * _suits.length
    }
    this.checkIndex = function (index = 0) {
        if (typeof index === 'number') {
            if (index >= 0 && index < this.getCountCard()) {
                return true;
            }
        }
        return false;
    }
    this.getUnicCard = function (index) {
        if (this.checkIndex(index)) {
            return {
                value: _values[index % _values.length],
                suit: _suits[index % _suits.length],
                strength: 6 + index % _values.length
            }
        }
    }
}

var Card = function (unicCard) {
    var _card = unicCard; //
    var _isTrump = false; //не козырн
    this.getSuit = function () {
        return _card.suit;
    }
    this.getStrength = function () {
        return _card.strength;
    }
    this.getValue = function () {
        return _card.value;
    }
    this.getTrumpStatus = function () {
        return _isTrump;
    }
    this.changeTrump = function (status = false) {
        if (_isTrump == false && status == true) {
            _isTrump = true;
            _card.strength += 1000;
        }
        if (_isTrump == true && status == false) {
            _isTrump = false;
            _card.strength -= 1000;
        }
    }
    this.toString = function () {
        return "Suit: " + this.getSuit() + " Strength: " + this.getStrength() + " Value: " + this.getValue() + " isTrump: " + _isTrump;
    }
}

var CardDeck = function () {
    var _cI = new CardInitializer();
    var _cards = [];
    var _currentTrumpSuit = null;

    var setTrumpSuit = function () {
        _currentTrumpSuit = _cards[Math.floor(Math.random() * _cI.getCountCard())].getSuit();
        _cards.forEach(function (item, index) {
            item.changeTrump(item.getSuit() == _currentTrumpSuit);
        });
    }
    var shuffle = function () {
        //тасования Фишера-Йетса
        var rV = 0;
        var temp = null;
        for (var i = 0; i < _cards.length; i++) {
            rV = Math.floor(Math.random() * i);
            temp = _cards[i];
            _cards[i] = _cards[rV];
            _cards[rV] = temp;
        }
    }
    this.getCountCard = function () {
        return _cI.getCountCard();
    }
    this.getOneCard = function (index) {
        if (_cI.checkIndex(index)) {
            return _cards[index];
        }
        return null;
    }
    this.getCurrentTrumpSuit = function () {
        return _currentTrumpSuit;
    }
    this.new = function () {
        for (let i = 0; i < _cI.getCountCard(); i++) {
            _cards[i] = new Card(_cI.getUnicCard(i));
        }
        setTrumpSuit();
        shuffle();
    }
    this.new();
}

var cd = new CardDeck();
for (var i = 0; i < cd.getCountCard(); i++) {
    console.log(cd.getOneCard(i).toString());
}


//Дз:карточную колоду переписать в стиле es6; (на class);