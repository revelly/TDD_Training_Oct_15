describe("Super Market spes",function(){
	var superMarket;
	beforeEach(function(){
		superMarket=SuperMarket;

		//add items to goods
		superMarket.goods.push("A");
		superMarket.goods.push("B");
		superMarket.goods.push("C");
		superMarket.goods.push("D");

		//add prices for the added items
		superMarket.billingPriceRules["A"]= 50;
		superMarket.billingPriceRules["B"]= 30;
		superMarket.billingPriceRules["C"]= 20;
		superMarket.billingPriceRules["D"]= 15;

		//add prices for the added items
		superMarket.billingPriceWithDiscountRules["AAA"]= 130;
		superMarket.billingPriceWithDiscountRules["BB"]= 45;
	});

	afterEach(function(){
		superMarket.shoppingCart=[];
		superMarket.goods=[];
	});

	it("super martket object should not return null", function(){
		expect(superMarket).not.toBe(null);
	});	

	it("super martket object should have goods object", function(){
		expect(superMarket.goods).not.toBe(undefined);
	});

	it("super martket object should have billing price rules object", function(){
		expect(superMarket.billingPriceRules).not.toBe(undefined);
	});	

	it("super martket object should have billingPriceWithDiscountRules method", function(){
		expect(superMarket.billingPriceWithDiscountRules).not.toBe(undefined);
	});	

	it("add one items should return count 1 in goods", function() {
		superMarket.goods=[];
		superMarket.goods.push("A");
		//console.log(superMarket.goods.length);
		expect(superMarket.goods.length == 1).toBeTruthy();
	})

	it("add two items should return count 2 in goods", function() {
		superMarket.goods=[];
		superMarket.goods.push("A");
		superMarket.goods.push("B");
		//console.log(superMarket.goods.length);
		expect(superMarket.goods.length == 2).toBeTruthy();
	})

	it("billingPriceRules should be greater than or equal to items in goods", function() {
		superMarket.goods=[]
		superMarket.goods.push("A");
		superMarket.billingPriceRules.A= 30;

		//console.log(superMarket.billingPriceRules.A);
		//console.log(Object.keys(superMarket.billingPriceRules).length);
		var lengthOfBillings=Object.keys(superMarket.billingPriceRules).length;
		expect(lengthOfBillings >= superMarket.goods.length).toBeTruthy();
	})

	it("super market object should have getPricing object", function(){
		expect(superMarket.getPricing).not.toBe(undefined);
	});

	it("provided no items in shoppingCart getPricing should return 0", function(){
		//console.log(superMarket.goods.length);
		var result=superMarket.getPricing();
		expect(result).toBe(0);
	});

	it("when item A added to shoppingCart getPricing should return 50", function(){
		superMarket.shoppingCart.push("A");
		superMarket.billingPriceRules["A"]= 50;

		var result = parseInt(superMarket.getPricing());
		expect(result).toBe(50);
	});

	it("when item A, B added to shoppingCart getPricing should return 80", function(){
		//add items to shoppingCart
		superMarket.shoppingCart.push("A");
		superMarket.shoppingCart.push("B");

		//add prices for the added items
		superMarket.billingPriceRules["A"]= 50;
		superMarket.billingPriceRules["B"]= 30;

		var result = parseInt(superMarket.getPricing());
		expect(result).toBe(80);
	});

	it("when item A, A, A to shoppingCart with 50 getPricing should return 150", function(){
		superMarket.shoppingCart=[];
		superMarket.shoppingCart.push("A");
		superMarket.shoppingCart.push("A");
		superMarket.shoppingCart.push("A");

		var result = parseInt(superMarket.getPricing());
		expect(result).toBe(150);
	});

	it("when item A, A, A to shoppingCart with 50 getPricing should return 150", function(){
		superMarket.shoppingCart=[];
		superMarket.shoppingCart.push("D");
		superMarket.shoppingCart.push("B");
		superMarket.shoppingCart.push("A");
		superMarket.shoppingCart.push("C");

		var result = parseInt(superMarket.getPricing());
		expect(result).toBe(115);
	});

	it("when item A, A, A to shoppingCart with billingPriceWithDiscountRules AAA=130 hasDiscount should return true", function(){
		superMarket.billingPriceWithDiscountRules=[];
		superMarket.billingPriceWithDiscountRules["AAA"]=130;
		
		superMarket.shoppingCart=[];
		superMarket.shoppingCart.push("A");
		superMarket.shoppingCart.push("A");
		superMarket.shoppingCart.push("A");

		var result = superMarket.hasDiscount();
		expect(result).toBeTruthy();
	});
	

});
