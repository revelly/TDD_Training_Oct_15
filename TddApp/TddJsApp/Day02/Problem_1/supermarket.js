var SuperMarket = {
	createTarget : function(){
		return this;
	},
	goods: [],
	billingPriceRules: [],
	billingPriceWithDiscountRules: [],
	getPricing:function(){
		var billAmount=0;

		if(this.shoppingCart.length == 0) return billAmount;

		for (var i = this.shoppingCart.length - 1; i >= 0; i--) {
			//console.log(this.shoppingCart[i]);
			//console.log(this.billingPriceRules[eval('"'+this.shoppingCart[i]+'"')]);
			billAmount+=  parseInt(this.billingPriceRules[eval('"'+this.shoppingCart[i]+'"')]);
		};

		return billAmount;
	},
	shoppingCart: [],
	isDiscountApplied: false,
	getDiscount: function(){
		//var pricing=parseInt(superMarket.getPricing());
	},
	applyDiscount: function(){
		if(!isDiscountApplied)
		{

		}
		else
			return 0;
	},
	hasDiscount: function (){
		var joinedCart = this.shoppingCart.join('');
		
		var getDiscountItemCounts= getKey(this.billingPriceWithDiscountRules, 0).length;
		console.log(getDiscountItemCounts);

		//var repeatCount = joinedCart.match(/A/g)||[]).length;

		/*
		if(repeatCount >= getDiscountItemCounts){
			return true;
		}
		else{ return false; }
		*/

		return true;
	},
	generateBilling: function(){},
	sampleGoods:{
		"A": {
			price: 50,
			discountRule: 3,
			discountprice: 150
		}
	}


}

function getItem(th, n){
        return th[Object.keys(th)[n]];
}
function getKey (th, n){
        return Object.keys(th)[n];
}
/*
Object.prototype.getItems=function(this, n){
        return this[Object.keys(this)[n]];
}
*/
