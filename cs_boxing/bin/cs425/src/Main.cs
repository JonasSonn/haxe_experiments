
#pragma warning disable 109, 114, 219, 429, 168, 162
public class EntryPoint__Main {
	public static void Main() {
		global::cs.Boot.init();
		global::Main.main();
	}
}

public class Main : global::haxe.lang.HxObject {
	
	public Main(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Main() {
		global::Main.__hx_ctor__Main(this);
	}
	
	
	protected static void __hx_ctor__Main(global::Main __hx_this) {
	}
	
	
	public static void main() {
		object s = new global::haxe.lang.DynamicObject(new int[]{98}, new object[]{((object) (1.0) )}, new int[]{97}, new double[]{((double) (0) )});
		global::Main.doSomething(s);
		object s2 = new global::haxe.lang.DynamicObject(new int[]{98}, new object[]{((object) (1.0) )}, new int[]{97}, new double[]{((double) (0) )});
		global::Main.doSomething2(s2);
		global::GenericType_Float_Null_Float g1 = new global::GenericType_Float_Null_Float(((double) (0.0) ), new global::haxe.lang.Null<double>(1.0, true));
		global::Main.doSomething3(g1);
	}
	
	
	public static bool doSomething(object s) {
		double t = ( global::haxe.lang.Runtime.getField_f(s, "a", 97, true) + 0.5 );
		double t_b = ( (global::haxe.lang.Null<object>.ofDynamic<double>(global::haxe.lang.Runtime.getField(s, "b", 98, true))).@value + 0.5 );
		return false;
	}
	
	
	public static bool doSomething2(object s) {
		double t = ( global::haxe.lang.Runtime.getField_f(s, "a", 97, true) + 0.5 );
		double t_b = ( (global::haxe.lang.Null<object>.ofDynamic<double>(global::haxe.lang.Runtime.getField(s, "b", 98, true))).@value + 0.5 );
		return false;
	}
	
	
	public static bool doSomething3(global::GenericType_Float_Null_Float s) {
		double t = ( s.a + 0.5 );
		double t_b = ( (s.b).@value + 0.5 );
		return false;
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class GenericType<T, B> : global::haxe.lang.HxObject, global::GenericType {
	
	public GenericType(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public GenericType(T a, B b) {
		global::GenericType<object, object>.__hx_ctor__GenericType<T, B>(((global::GenericType<T, B>) (this) ), global::haxe.lang.Runtime.genericCast<T>(a), global::haxe.lang.Runtime.genericCast<B>(b));
	}
	
	
	protected static void __hx_ctor__GenericType<T_c, B_c>(global::GenericType<T_c, B_c> __hx_this, T_c a, B_c b) {
		__hx_this.a = a;
		__hx_this.b = b;
	}
	
	
	public static object __hx_cast<T_c_c, B_c_c>(global::GenericType me) {
		return ( (( me != null )) ? (me.GenericType_cast<T_c_c, B_c_c>()) : default(object) );
	}
	
	
	public virtual object GenericType_cast<T_c, B_c>() {
		if (( global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c)) && global::haxe.lang.Runtime.eq(typeof(B), typeof(B_c)) )) {
			return this;
		}
		
		global::GenericType<T_c, B_c> new_me = new global::GenericType<T_c, B_c>(global::haxe.lang.EmptyObject.EMPTY);
		global::Array<string> fields = global::Reflect.fields(this);
		int i = 0;
		while (( i < fields.length )) {
			string field = fields[i++];
			global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
		}
		
		return new_me;
	}
	
	
	public T a;
	
	public B b;
	
	public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 98:
				{
					this.b = global::haxe.lang.Runtime.genericCast<B>(((object) (@value) ));
					return ((double) (global::haxe.lang.Runtime.toDouble(((object) (@value) ))) );
				}
				
				
				case 97:
				{
					this.a = global::haxe.lang.Runtime.genericCast<T>(((object) (@value) ));
					return ((double) (global::haxe.lang.Runtime.toDouble(((object) (@value) ))) );
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
					this.b = global::haxe.lang.Runtime.genericCast<B>(@value);
					return @value;
				}
				
				
				case 97:
				{
					this.a = global::haxe.lang.Runtime.genericCast<T>(@value);
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
					return this.b;
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
				case 98:
				{
					return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.b) ))) );
				}
				
				
				case 97:
				{
					return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.a) ))) );
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



#pragma warning disable 109, 114, 219, 429, 168, 162
[global::haxe.lang.GenericInterface(typeof(global::GenericType<object, object>))]
public interface GenericType : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
	
	object GenericType_cast<T_c, B_c>();
	
}


