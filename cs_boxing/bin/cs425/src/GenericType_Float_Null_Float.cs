
#pragma warning disable 109, 114, 219, 429, 168, 162
public class GenericType_Float_Null_Float : global::haxe.lang.HxObject {
	
	public GenericType_Float_Null_Float(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public GenericType_Float_Null_Float(double a, global::haxe.lang.Null<double> b) {
		global::GenericType_Float_Null_Float.__hx_ctor__GenericType_Float_Null_Float(this, a, b);
	}
	
	
	protected static void __hx_ctor__GenericType_Float_Null_Float(global::GenericType_Float_Null_Float __hx_this, double a, global::haxe.lang.Null<double> b) {
		__hx_this.a = a;
		__hx_this.b = b;
	}
	
	
	public double a;
	
	public global::haxe.lang.Null<double> b;
	
	public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 97:
				{
					this.a = ((double) (@value) );
					return @value;
				}
				
				
				default:
				{
					return base.__hx_setField_f(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 98:
				{
					this.b = global::haxe.lang.Null<object>.ofDynamic<double>(@value);
					return @value;
				}
				
				
				case 97:
				{
					this.a = ((double) (global::haxe.lang.Runtime.toDouble(@value)) );
					return @value;
				}
				
				
				default:
				{
					return base.__hx_setField(field, hash, @value, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 98:
				{
					return (this.b).toDynamic();
				}
				
				
				case 97:
				{
					return this.a;
				}
				
				
				default:
				{
					return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 97:
				{
					return this.a;
				}
				
				
				default:
				{
					return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override void __hx_getFields(global::Array<string> baseArr) {
		baseArr.push("b");
		baseArr.push("a");
		base.__hx_getFields(baseArr);
	}
	
	
}


