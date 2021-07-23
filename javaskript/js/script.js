(function () {
    // наследование - 
    // инкапсуляция - 
    // полиморфизм - 
    // Object

    //    var Person = {
    //        age:15,
    //        getAge:function(){
    //            return this.age;
    //        }
    //    };
    //    
    //    Person.age = "Вася";
    //    console.log(Person.age);
    //    console.log(Person.getAge);
    //    console.log(Person.getAge());
    //    console.log("Мне " + Person.age + " лет");
    //    
    //    Person.name = "Василий";
    //    Person.getName = function(){
    //        return this.name;
    //    }

    var Person = function (name, age) {
        var _age = 0; //private
        //        this._age = age; //public
        //        this._name = name; //public

        this.getAge = function () { //public
            return _age;
        }
        this.setAge = function (age = 0) {
            age = parseInt(age);
            if (!isNaN(age)) {
                if (age >= 0 && age < 150) {
                    _age = age;
                } else {
                    console.error("Person -> setAge -> incorrect range value");
                }
            } else {
                console.error("Person -> setAge -> vrong type value");
            }
        }
        this.setAge(age);
    };

    var anna = new Person("Анна", 25);
    var petja = new Person("Петр", 30);

    //    console.log(anna._name);
    //    console.log(anna._age);
    //    console.log(petja._name);
    //    console.log(petja._age);
    //    anna.field_1 = 10;
    //    
    //    console.log(anna.field_1);
    //    console.log(petja.field_1);
    //    console.log(anna.age);
    console.log(anna.getAge());
    anna.setAge(["36Вася"]);
    console.log(anna.getAge());
})();
