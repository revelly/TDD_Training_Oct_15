describe("Hello Specs", function () {
    it("Should print hello given name", function () {
        var message = sayHello("Ravi");
        expect(message).toBe("Hello Ravi");
    });

    it("Should print hello given name2", function () {
        var message = sayHello("Ravi1");
        expect(message).toBe("Hello Ravi1");
    });
});

describe("Hello Specs2", function () {
    it("Should print hello given name", function () {
        var message = sayHello("Ravi");
        expect(message).toBe("Hello Ravi");
    });
});