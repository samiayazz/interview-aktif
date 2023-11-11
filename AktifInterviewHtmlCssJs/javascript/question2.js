const object = {
    name: 'Sami',
    surname: "Ayaz",
    age: 21,

    setId: function (name, surname, age) {
        this.id = name.charAt(0) + surname.charAt(0) + age;
        return this;
    },
    setIdWithThisKeyword: function (name, surname, age) {
        this.id = this.name.charAt(0) + this.surname.charAt(0) + this.age;
        return this;
    }
}

console.log(object.setId("John", "Doe", 18).id);
console.log(object.setIdWithThisKeyword("John", "Doe", 18).id);