
namespace haxe.lang{
	public enum EmptyObject{
		EMPTY
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Runtime {
		
		
	public static object getField(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return null;
		return obj.__hx_getField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false, false);
	}

	public static double getField_f(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return 0.0;
		return obj.__hx_getField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false);
	}

	public static object setField(haxe.lang.HxObject obj, string field, int fieldHash, object value)
	{
		return obj.__hx_setField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}

	public static double setField_f(haxe.lang.HxObject obj, string field, int fieldHash, double value)
	{
		return obj.__hx_setField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}

	public static object callField(haxe.lang.HxObject obj, string field, int fieldHash, object[] args)
	{
		return obj.__hx_invokeField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, args);
	}
		public Runtime() {
		}
		
		
		public static readonly object undefined = ((object) (new global::System.Object()) );
		
		public static object closure(object obj, int hash, string field) {
			return new global::haxe.lang.Closure(obj, field, hash);
		}
		
		
		public static bool eq(object v1, object v2) {
			if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ))) {
				return true;
			}
			
			if (( global::System.Object.ReferenceEquals(((object) (v1) ), default(object)) || global::System.Object.ReferenceEquals(((object) (v2) ), default(object)) )) {
				return false;
			}
			
			global::System.IConvertible v1c = ( v1 as global::System.IConvertible );
			if (( v1c != null )) {
				global::System.IConvertible v2c = ( v2 as global::System.IConvertible );
				if (( v2c == null )) {
					return false;
				}
				
				global::System.TypeCode t1 = v1c.GetTypeCode();
				global::System.TypeCode t2 = v2c.GetTypeCode();
				if (( t1 == t2 )) {
					return global::System.Object.Equals(((object) (v1c) ), ((object) (v2c) ));
				}
				
				if (( ( t1 == global::System.TypeCode.String ) || ( t2 == global::System.TypeCode.String ) )) {
					return false;
				}
				
				switch (t1) {
					case global::System.TypeCode.Int64:
					{
						switch (t2) {
							case global::System.TypeCode.Int64:
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							case global::System.TypeCode.DateTime:
							{
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.UInt64:
					case global::System.TypeCode.DateTime:
					{
						switch (t2) {
							case global::System.TypeCode.Int64:
							{
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							case global::System.TypeCode.DateTime:
							{
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.Single:
					case global::System.TypeCode.Double:
					{
						switch (t2) {
							case global::System.TypeCode.Int64:
							{
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.DateTime:
							{
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							{
								return ( v1c.ToDouble(default(global::System.IFormatProvider)) == v2c.ToDouble(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								return ( v1c.ToDouble(default(global::System.IFormatProvider)) == v2c.ToDouble(default(global::System.IFormatProvider)) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.Decimal:
					{
						return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
					}
					
					
					default:
					{
						switch (t2) {
							case global::System.TypeCode.Int64:
							{
								return ( ((long) (v1c.ToInt64(default(global::System.IFormatProvider))) ) == ((long) (v2c.ToInt64(default(global::System.IFormatProvider))) ) );
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.DateTime:
							{
								return ( v1c.ToUInt64(default(global::System.IFormatProvider)) == v2c.ToUInt64(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Single:
							case global::System.TypeCode.Double:
							{
								return ( v1c.ToDouble(default(global::System.IFormatProvider)) == v2c.ToDouble(default(global::System.IFormatProvider)) );
							}
							
							
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(default(global::System.IFormatProvider)).Equals(v2c.ToDecimal(default(global::System.IFormatProvider)));
							}
							
							
							default:
							{
								return ( v1c.ToInt32(default(global::System.IFormatProvider)) == v2c.ToInt32(default(global::System.IFormatProvider)) );
							}
							
						}
						
					}
					
				}
				
			}
			
			global::System.ValueType v1v = ( v1 as global::System.ValueType );
			if (( v1v != null )) {
				return v1.Equals(v2);
			}
			else {
				global::System.Type v1t = ( v1 as global::System.Type );
				if (( v1t != null )) {
					global::System.Type v2t = ( v2 as global::System.Type );
					if (( v2t != null )) {
						return global::haxe.lang.Runtime.typeEq(v1t, v2t);
					}
					
					return false;
				}
				
			}
			
			return false;
		}
		
		
		public static bool refEq(object v1, object v2) {
			if (( v1 is global::System.Type )) {
				return global::haxe.lang.Runtime.typeEq(( ((object) (v1) ) as global::System.Type ), ( ((object) (v2) ) as global::System.Type ));
			}
			
			return global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ));
		}
		
		
		public static double toDouble(object obj) {
			if (( obj == null )) {
				return .0;
			}
			else if (( obj is double )) {
				return ((double) (obj) );
			}
			else {
				return ( obj as global::System.IConvertible ).ToDouble(default(global::System.IFormatProvider));
			}
			
		}
		
		
		public static int toInt(object obj) {
			if (( obj == null )) {
				return 0;
			}
			else if (( obj is int )) {
				return ((int) (obj) );
			}
			else {
				return ( obj as global::System.IConvertible ).ToInt32(default(global::System.IFormatProvider));
			}
			
		}
		
		
		public static bool isInt(object obj) {
			global::System.IConvertible cv1 = ( obj as global::System.IConvertible );
			if (( cv1 != null )) {
				switch (cv1.GetTypeCode()) {
					case global::System.TypeCode.Int32:
					case global::System.TypeCode.UInt32:
					{
						return true;
					}
					
					
					case global::System.TypeCode.Double:
					{
						double d = ((double) (obj) );
						if (( ( d >= global::System.Int32.MinValue ) && ( d <= global::System.Int32.MaxValue ) )) {
							return ( d == ((int) (d) ) );
						}
						else {
							return false;
						}
						
					}
					
					
					default:
					{
						return false;
					}
					
				}
				
			}
			
			return false;
		}
		
		
		public static bool isUInt(object obj) {
			global::System.IConvertible cv1 = ( obj as global::System.IConvertible );
			if (( cv1 != null )) {
				switch (cv1.GetTypeCode()) {
					case global::System.TypeCode.UInt32:
					{
						return true;
					}
					
					
					case global::System.TypeCode.Double:
					{
						double d = ((double) (obj) );
						if (( ( d >= global::System.UInt32.MinValue ) && ( d <= global::System.UInt32.MaxValue ) )) {
							return ( ((uint) (d) ) == d );
						}
						else {
							return false;
						}
						
					}
					
					
					default:
					{
						return false;
					}
					
				}
				
			}
			
			return false;
		}
		
		
		public static int compare(object v1, object v2) {
			unchecked {
				if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ))) {
					return 0;
				}
				
				if (global::System.Object.ReferenceEquals(((object) (v1) ), default(object))) {
					return -1;
				}
				
				if (global::System.Object.ReferenceEquals(((object) (v2) ), default(object))) {
					return 1;
				}
				
				global::System.IConvertible cv1 = ( v1 as global::System.IConvertible );
				if (( cv1 != null )) {
					global::System.IConvertible cv2 = ( v2 as global::System.IConvertible );
					if (( cv2 == null )) {
						throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
					}
					
					switch (cv1.GetTypeCode()) {
						case global::System.TypeCode.Double:
						{
							double d1 = ((double) (v1) );
							double d2 = cv2.ToDouble(default(global::System.IFormatProvider));
							if (( d1 < d2 )) {
								return -1;
							}
							else if (( d1 > d2 )) {
								return 1;
							}
							else {
								return 0;
							}
							
						}
						
						
						case global::System.TypeCode.String:
						{
							if (( cv2.GetTypeCode() != global::System.TypeCode.String )) {
								throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
							}
							
							string s1 = ( v1 as string );
							string s2 = ( v2 as string );
							return string.Compare(((string) (s1) ), ((string) (s2) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
						}
						
						
						default:
						{
							double d1d = cv1.ToDouble(default(global::System.IFormatProvider));
							double d2d = cv2.ToDouble(default(global::System.IFormatProvider));
							if (( d1d < d2d )) {
								return -1;
							}
							else if (( d1d > d2d )) {
								return 1;
							}
							else {
								return 0;
							}
							
						}
						
					}
					
				}
				
				global::System.IComparable c1 = ( v1 as global::System.IComparable );
				global::System.IComparable c2 = ( v2 as global::System.IComparable );
				if (( ( c1 == null ) || ( c2 == null ) )) {
					throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
				}
				
				return c1.CompareTo(((object) (c2) ));
			}
		}
		
		
		public static object plus(object v1, object v2) {
			if (( ( v1 is string ) || ( v2 is string ) )) {
				return global::haxe.lang.Runtime.concat(global::Std.@string(v1), global::Std.@string(v2));
			}
			
			if (( v1 == null )) {
				if (( v2 == null )) {
					return null;
				}
				
				v1 = 0;
			}
			else if (( v2 == null )) {
				v2 = 0;
			}
			
			global::System.IConvertible cv1 = ( v1 as global::System.IConvertible );
			if (( cv1 != null )) {
				global::System.IConvertible cv2 = ( v2 as global::System.IConvertible );
				if (( cv2 == null )) {
					throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot dynamically add ", v1.GetType().ToString()), " and "), v2.GetType().ToString()));
				}
				
				return ( cv1.ToDouble(default(global::System.IFormatProvider)) + cv2.ToDouble(default(global::System.IFormatProvider)) );
			}
			
			throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot dynamically add ", global::Std.@string(v1)), " and "), global::Std.@string(v2)));
		}
		
		
		public static object slowGetField(object obj, string field, bool throwErrors) {
			if (( obj == null )) {
				if (throwErrors) {
					throw new global::System.NullReferenceException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\' of null."));
				}
				else {
					return null;
				}
				
			}
			
			global::System.Type t = ( obj as global::System.Type );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				string s = ( obj as string );
				if (( s != null )) {
					return global::haxe.lang.StringRefl.handleGetField(s, field, throwErrors);
				}
				
				t = ((global::System.Type) (obj.GetType()) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				if (( ( t == ((global::System.Type) (typeof(string)) ) ) && ( field == "fromCharCode" ) )) {
					return new global::haxe.lang.Closure(typeof(global::haxe.lang.StringExt), field, 0);
				}
				
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			global::System.Reflection.FieldInfo f = t.GetField(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( f != null )) {
				return global::haxe.lang.Runtime.unbox(f.GetValue(((object) (obj) )));
			}
			else {
				global::System.Reflection.PropertyInfo prop = t.GetProperty(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
				if (( prop == null )) {
					global::System.Reflection.MemberInfo[] m = t.GetMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
					if (( ( ( m as global::System.Array ).Length == 0 ) && (( ( field == "__get" ) || ( field == "__set" ) )) )) {
						m = t.GetMember(((string) (( (( field == "__get" )) ? ("get_Item") : ("set_Item") )) ), ((global::System.Reflection.BindingFlags) (bf) ));
					}
					
					if (( ( m as global::System.Array ).Length > 0 )) {
						return new global::haxe.lang.Closure(( (( obj != null )) ? (obj) : ((object) (t) ) ), field, 0);
					}
					else {
						if (t.IsCOMObject) {
							try {
								return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.GetProperty) ), default(global::System.Reflection.Binder), ((object) (obj) ), ((object[]) (new object[0]) ));
							}
							catch (global::System.Exception e){
							}
							
							
						}
						
						if (throwErrors) {
							throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\'."))) );
						}
						else {
							return null;
						}
						
					}
					
				}
				
				return global::haxe.lang.Runtime.unbox(prop.GetValue(((object) (obj) ), default(object[])));
			}
			
		}
		
		
		public static bool slowHasField(object obj, string field) {
			if (( obj == null )) {
				return false;
			}
			
			global::System.Type t = ( obj as global::System.Type );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				string s = ( obj as string );
				if (( s != null )) {
					return ( global::haxe.lang.StringRefl.handleGetField(s, field, false) != null );
				}
				
				t = ((global::System.Type) (obj.GetType()) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				if (( t == ((global::System.Type) (typeof(string)) ) )) {
					return ( field == "fromCharCode" );
				}
				
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			global::System.Reflection.MemberInfo[] mi = t.GetMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( mi != null )) {
				return ( ( mi as global::System.Array ).Length > 0 );
			}
			else {
				return false;
			}
			
		}
		
		
		public static object slowSetField(object obj, string field, object @value) {
			if (( obj == null )) {
				throw new global::System.NullReferenceException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\' of null."));
			}
			
			global::System.Type t = ( obj as global::System.Type );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				t = ((global::System.Type) (obj.GetType()) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			global::System.Reflection.FieldInfo f = t.GetField(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( f != null )) {
				if (f.FieldType.ToString().StartsWith("haxe.lang.Null")) {
					@value = global::haxe.lang.Runtime.mkNullable(@value, f.FieldType);
				}
				
				if (( ( ( @value != null ) && global::System.Object.ReferenceEquals(((global::System.Type) (typeof(global::System.Double)) ), ((object) (@value.GetType()) )) ) &&  ! (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (f.FieldType) )))  )) {
					global::System.IConvertible ic = ( @value as global::System.IConvertible );
					@value = ic.ToType(((global::System.Type) (f.FieldType) ), default(global::System.IFormatProvider));
				}
				
				f.SetValue(((object) (obj) ), ((object) (@value) ));
				return @value;
			}
			else {
				global::System.Reflection.PropertyInfo prop = t.GetProperty(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
				if (( prop == null )) {
					if (t.IsCOMObject) {
						try {
							return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.SetProperty) ), default(global::System.Reflection.Binder), ((object) (obj) ), ((object[]) (new object[]{((object) (@value) )}) ));
						}
						catch (global::System.Exception e){
						}
						
						
					}
					
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Field \'", field), "\' not found for writing from Class "), global::Std.@string(t)))) );
				}
				
				if (prop.PropertyType.ToString().StartsWith("haxe.lang.Null")) {
					@value = global::haxe.lang.Runtime.mkNullable(@value, prop.PropertyType);
				}
				
				if (( global::System.Object.ReferenceEquals(((global::System.Type) (typeof(global::System.Double)) ), ((object) (@value.GetType()) )) &&  ! (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (prop.PropertyType) )))  )) {
					global::System.IConvertible ic1 = ( @value as global::System.IConvertible );
					@value = ic1.ToType(((global::System.Type) (prop.PropertyType) ), default(global::System.IFormatProvider));
				}
				
				prop.SetValue(((object) (obj) ), ((object) (@value) ), default(object[]));
				return @value;
			}
			
		}
		
		
		public static object callMethod(object obj, global::System.Reflection.MethodBase[] methods, int methodLength, object[] args) {
			unchecked {
				if (( methodLength == 0 )) {
					throw ((global::System.Exception) (global::haxe.Exception.thrown("No available methods")) );
				}
				
				int length = ( args as global::System.Array ).Length;
				object[] oargs = new object[length];
				global::System.Type[] ts = new global::System.Type[length];
				int[] rates = new int[( methods as global::System.Array ).Length];
				{
					int _g = 0;
					int _g1 = length;
					while (( _g < _g1 )) {
						int i = _g++;
						oargs[i] = args[i];
						if (( args[i] != null )) {
							ts[i] = args[i].GetType();
						}
						
					}
					
				}
				
				int last = 0;
				if (( methodLength > 1 )) {
					{
						int _g2 = 0;
						int _g3 = methodLength;
						while (( _g2 < _g3 )) {
							int i1 = _g2++;
							global::System.Reflection.ParameterInfo[] @params = ((global::System.Reflection.MethodBase) (methods[i1]) ).GetParameters();
							if (( ( @params as global::System.Array ).Length != length )) {
								continue;
							}
							else {
								bool fits = true;
								int crate = 0;
								{
									int _g4 = 0;
									int _g5 = ( @params as global::System.Array ).Length;
									while (( _g4 < _g5 )) {
										int i2 = _g4++;
										global::System.Type param = ((global::System.Reflection.ParameterInfo) (@params[i2]) ).ParameterType;
										string strParam = global::haxe.lang.Runtime.concat(global::Std.@string(param), "");
										if (( param.IsAssignableFrom(((global::System.Type) (ts[i2]) )) || ( ( ((global::System.Type) (ts[i2]) ) == null ) &&  ! (param.IsValueType)  ) )) {
											continue;
										}
										else if (( strParam.StartsWith("haxe.lang.Null") || ( (( ( oargs[i2] == null ) || ( oargs[i2] is global::System.IConvertible ) )) && (((global::System.Type) (typeof(global::System.IConvertible)) )).IsAssignableFrom(((global::System.Type) (param) )) ) )) {
											 ++ crate;
											continue;
										}
										else if ( ! (param.ContainsGenericParameters) ) {
											fits = false;
											break;
										}
										
									}
									
								}
								
								if (fits) {
									rates[last] = crate;
									methods[last++] = ((global::System.Reflection.MethodBase) (methods[i1]) );
								}
								
							}
							
						}
						
					}
					
					methodLength = last;
				}
				else if (( ( methodLength == 1 ) && ( ( ((global::System.Reflection.MethodBase) (methods[0]) ).GetParameters() as global::System.Array ).Length != length ) )) {
					methodLength = 0;
				}
				
				if (( methodLength == 0 )) {
					throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat("Invalid calling parameters for method ", ( ((global::System.Reflection.MethodBase) (methods[0]) ) as global::System.Reflection.MemberInfo ).Name))) );
				}
				
				double best = global::System.Double.PositiveInfinity;
				int bestMethod = 0;
				{
					int _g6 = 0;
					int _g7 = methodLength;
					while (( _g6 < _g7 )) {
						int i3 = _g6++;
						if (( rates[i3] < best )) {
							bestMethod = i3;
							best = ((double) (rates[i3]) );
						}
						
					}
					
				}
				
				methods[0] = ((global::System.Reflection.MethodBase) (methods[bestMethod]) );
				global::System.Reflection.ParameterInfo[] params1 = ((global::System.Reflection.MethodBase) (methods[0]) ).GetParameters();
				{
					int _g8 = 0;
					int _g9 = ( params1 as global::System.Array ).Length;
					while (( _g8 < _g9 )) {
						int i4 = _g8++;
						global::System.Type param1 = ((global::System.Reflection.ParameterInfo) (params1[i4]) ).ParameterType;
						string strParam1 = global::haxe.lang.Runtime.concat(global::Std.@string(param1), "");
						object arg = oargs[i4];
						if (strParam1.StartsWith("haxe.lang.Null")) {
							oargs[i4] = global::haxe.lang.Runtime.mkNullable(arg, param1);
						}
						else if ((((global::System.Type) (typeof(global::System.IConvertible)) )).IsAssignableFrom(((global::System.Type) (param1) ))) {
							if (( arg == null )) {
								if (param1.IsValueType) {
									oargs[i4] = global::System.Activator.CreateInstance(((global::System.Type) (param1) ));
								}
								
							}
							else if ( ! (((object) (arg) ).GetType().IsAssignableFrom(((global::System.Type) (param1) ))) ) {
								oargs[i4] = (((global::System.IConvertible) (arg) )).ToType(((global::System.Type) (param1) ), default(global::System.IFormatProvider));
							}
							
						}
						
					}
					
				}
				
				if (( ((global::System.Reflection.MethodBase) (methods[0]) ).ContainsGenericParameters && ( ((global::System.Reflection.MethodBase) (methods[0]) ) is global::System.Reflection.MethodInfo ) )) {
					global::System.Reflection.MethodInfo m = ((global::System.Reflection.MethodInfo) (((global::System.Reflection.MethodBase) (methods[0]) )) );
					global::System.Type[] tgs = ( m as global::System.Reflection.MethodBase ).GetGenericArguments();
					{
						int _g10 = 0;
						int _g11 = ( tgs as global::System.Array ).Length;
						while (( _g10 < _g11 )) {
							int i5 = _g10++;
							tgs[i5] = typeof(object);
						}
						
					}
					
					m = m.MakeGenericMethod(((global::System.Type[]) (tgs) ));
					object retg = null;
					try {
						retg = ( m as global::System.Reflection.MethodBase ).Invoke(((object) (obj) ), ((object[]) (oargs) ));
					}
					catch (global::System.Reflection.TargetInvocationException e){
						throw ( e as global::System.Exception ).InnerException;
					}
					
					
					return global::haxe.lang.Runtime.unbox(retg);
				}
				
				global::System.Reflection.MethodBase m1 = ((global::System.Reflection.MethodBase) (methods[0]) );
				if (( ( obj == null ) && ( m1 is global::System.Reflection.ConstructorInfo ) )) {
					object ret = null;
					try {
						ret = (((global::System.Reflection.ConstructorInfo) (m1) )).Invoke(((object[]) (oargs) ));
					}
					catch (global::System.Reflection.TargetInvocationException e1){
						throw ( e1 as global::System.Exception ).InnerException;
					}
					
					
					return global::haxe.lang.Runtime.unbox(ret);
				}
				
				object ret1 = null;
				try {
					ret1 = m1.Invoke(((object) (obj) ), ((object[]) (oargs) ));
				}
				catch (global::System.Reflection.TargetInvocationException e2){
					throw ( e2 as global::System.Exception ).InnerException;
				}
				
				
				return global::haxe.lang.Runtime.unbox(ret1);
			}
		}
		
		
		public static object unbox(object dyn) {
			if (( ( dyn != null ) && (global::haxe.lang.Runtime.concat(global::Std.@string(dyn.GetType()), "")).StartsWith("haxe.lang.Null") )) {
				return ((object) (global::haxe.lang.Runtime.callField(dyn, "toDynamic", 1705629508, null)) );
			}
			else {
				return dyn;
			}
			
		}
		
		
		public static object mkNullable(object obj, global::System.Type nullableType) {
			
		if (nullableType.ContainsGenericParameters)
			return haxe.lang.Null<object>.ofDynamic<object>(obj);
		return nullableType.GetMethod("_ofDynamic").Invoke(null, new object[] { obj });
	
		}
		
		
		public static object slowCallField(object obj, string field, object[] args) {
			if (( ( field == "toString" ) && (( ( args == null ) || ( ( args as global::System.Array ).Length == 0 ) )) )) {
				return obj.ToString();
			}
			
			if (( args == null )) {
				args = new object[0];
			}
			
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			global::System.Type t = ( obj as global::System.Type );
			if (( t == null )) {
				string s = ( obj as string );
				if (( s != null )) {
					return global::haxe.lang.StringRefl.handleCallField(s, field, args);
				}
				
				t = obj.GetType();
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Instance, true);
				global::System.Reflection.BindingFlags this1 = ( ( ! (initial.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial1 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this1) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this2 = ( ( ! (initial1.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial1).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial2 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this2) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) ), true);
				global::System.Reflection.BindingFlags this3 = ( ( ! (initial2.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial2).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this3) );
			}
			else {
				if (( ( t == ((global::System.Type) (typeof(string)) ) ) && ( field == "fromCharCode" ) )) {
					return global::haxe.lang.StringExt.fromCharCode(global::haxe.lang.Runtime.toInt(args[0]));
				}
				
				obj = null;
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial3 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(global::System.Reflection.BindingFlags.Static, true);
				global::System.Reflection.BindingFlags this4 = ( ( ! (initial3.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial3).@value) );
				global::haxe.lang.Null<global::System.Reflection.BindingFlags> initial4 = new global::haxe.lang.Null<global::System.Reflection.BindingFlags>(( ((global::System.Reflection.BindingFlags) (this4) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) ), true);
				global::System.Reflection.BindingFlags this5 = ( ( ! (initial4.hasValue) ) ? (default(global::System.Reflection.BindingFlags)) : ((initial4).@value) );
				bf = ((global::System.Reflection.BindingFlags) (this5) );
			}
			
			global::System.Reflection.MethodBase[] mis = t.GetMethods(((global::System.Reflection.BindingFlags) (bf) ));
			int last = 0;
			{
				int _g = 0;
				int _g1 = ( mis as global::System.Array ).Length;
				while (( _g < _g1 )) {
					int i = _g++;
					string name = ( ((global::System.Reflection.MethodBase) (mis[i]) ) as global::System.Reflection.MemberInfo ).Name;
					if (( name == field )) {
						mis[last++] = ((global::System.Reflection.MethodBase) (mis[i]) );
					}
					
				}
				
			}
			
			if (( ( last == 0 ) && (( ( field == "__get" ) || ( field == "__set" ) )) )) {
				field = ( (( field == "__get" )) ? ("get_Item") : ("set_Item") );
				{
					int _g2 = 0;
					int _g3 = ( mis as global::System.Array ).Length;
					while (( _g2 < _g3 )) {
						int i1 = _g2++;
						string name1 = ( ((global::System.Reflection.MethodBase) (mis[i1]) ) as global::System.Reflection.MemberInfo ).Name;
						if (( name1 == field )) {
							mis[last++] = ((global::System.Reflection.MethodBase) (mis[i1]) );
						}
						
					}
					
				}
				
			}
			
			if (( ( last == 0 ) && t.IsCOMObject )) {
				return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.InvokeMethod) ), default(global::System.Reflection.Binder), ((object) (obj) ), ((object[]) (args) ));
			}
			
			if (( last == 0 )) {
				throw ((global::System.Exception) (global::haxe.Exception.thrown(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Method \"", field), "\" not found on type "), global::Std.@string(t)))) );
			}
			
			return global::haxe.lang.Runtime.callMethod(obj, mis, last, args);
		}
		
		
		public static object callField(object obj, string field, int fieldHash, object[] args) {
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				return hxObj.__hx_invokeField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), args);
			}
			
			return global::haxe.lang.Runtime.slowCallField(obj, field, args);
		}
		
		
		public static object getField(object obj, string field, int fieldHash, bool throwErrors) {
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				return hxObj.__hx_getField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), throwErrors, false, false);
			}
			
			return global::haxe.lang.Runtime.slowGetField(obj, field, throwErrors);
		}
		
		
		public static double getField_f(object obj, string field, int fieldHash, bool throwErrors) {
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				return hxObj.__hx_getField_f(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), throwErrors, false);
			}
			
			return global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.slowGetField(obj, field, throwErrors));
		}
		
		
		public static object setField(object obj, string field, int fieldHash, object @value) {
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				return hxObj.__hx_setField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), @value, false);
			}
			
			return global::haxe.lang.Runtime.slowSetField(obj, field, @value);
		}
		
		
		public static double setField_f(object obj, string field, int fieldHash, double @value) {
			global::haxe.lang.HxObject hxObj = ( obj as global::haxe.lang.HxObject );
			if (( hxObj != null )) {
				return hxObj.__hx_setField_f(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), @value, false);
			}
			
			return global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.slowSetField(obj, field, @value));
		}
		
		
		public static string toString(object obj) {
			if (( obj == null )) {
				return null;
			}
			
			if (( obj is bool )) {
				if (global::haxe.lang.Runtime.toBool((obj))) {
					return "true";
				}
				else {
					return "false";
				}
				
			}
			
			return obj.ToString();
		}
		
		
		public static bool typeEq(global::System.Type t1, global::System.Type t2) {
			if (( ( t1 == null ) || ( t2 == null ) )) {
				return ( t1 == t2 );
			}
			
			bool t1i = t1.IsInterface;
			bool t2i = t2.IsInterface;
			if (( t1i != t2i )) {
				if (t1i) {
					global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(t1);
					if (( g != null )) {
						t1 = g.generic;
					}
					
				}
				else {
					global::haxe.lang.GenericInterface g1 = global::haxe.lang.Runtime.getGenericAttr(t2);
					if (( g1 != null )) {
						t2 = g1.generic;
					}
					
				}
				
			}
			
			if (( ( t1.GetGenericArguments() as global::System.Array ).Length > 0 )) {
				t1 = t1.GetGenericTypeDefinition();
			}
			
			if (( ( t2.GetGenericArguments() as global::System.Array ).Length > 0 )) {
				t2 = t2.GetGenericTypeDefinition();
			}
			
			return global::System.Object.ReferenceEquals(((object) (t1) ), ((object) (t2) ));
		}
		
		
		public static global::haxe.lang.GenericInterface getGenericAttr(global::System.Type t) {
			unchecked {
				{
					object[] _g_arr = ( t as global::System.Reflection.MemberInfo ).GetCustomAttributes(((bool) (true) ));
					uint _g_idx = ((uint) (0) );
					while (( _g_idx < ( _g_arr as global::System.Array ).Length )) {
						_g_idx += ((uint) (1) );
						object attr = ((object) (_g_arr[((int) (((uint) (( _g_idx - 1 )) )) )]) );
						if (( attr is global::haxe.lang.GenericInterface )) {
							return ((global::haxe.lang.GenericInterface) (attr) );
						}
						
					}
					
				}
				
				return null;
			}
		}
		
		
		public static To genericCast<To>(object obj) {
			
		if (obj is To)
			return (To) obj;
		else if (obj == null)
			return default(To);
		if (typeof(To) == typeof(double))
			return (To)(object) toDouble(obj);
		else if (typeof(To) == typeof(int))
			return (To)(object) toInt(obj);
		else if (typeof(To) == typeof(float))
			return (To)(object)(float)toDouble(obj);
		else if (typeof(To) == typeof(long))
			return (To)(object)(long)toDouble(obj);
		else
			return (To) obj;
	
		}
		
		
		public static string concat(string s1, string s2) {
			
		return (s1 == null ? "null" : s1) + (s2 == null ? "null" : s2);
	
		}
		
		
		public static bool toBool(object dyn) {
			if (( dyn == null )) {
				return false;
			}
			else {
				return (bool)dyn;
			}
			
		}
		
		
	}
}


