
#pragma warning disable 109, 114, 219, 429, 168, 162
public sealed class Array<T> : global::haxe.lang.HxObject, global::Array {
	
	static bool __hx_init_called = false;
	static Array() {
		if(global::Array<object>.__hx_init_called) return;
		global::Array<object>.__hx_init_called = true;
		unchecked{
			global::Array<object>.__hx_toString_depth = 0;
			global::Array<object>.__hx_defaultCapacity = 4;
		}
		
	}
	
	
	public Array(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Array(T[] native) {
		global::Array<object>.__hx_ctor__Array<T>(((global::Array<T>) (this) ), ((T[]) (native) ));
	}
	
	
	public Array() {
		global::Array<object>.__hx_ctor__Array<T>(((global::Array<T>) (this) ));
	}
	
	
	private static void __hx_ctor__Array<T_c>(global::Array<T_c> __hx_this, T_c[] native) {
		__hx_this.length = ( native as global::System.Array ).Length;
		__hx_this.__a = native;
	}
	
	
	private static void __hx_ctor__Array<T_c>(global::Array<T_c> __hx_this) {
		__hx_this.length = 0;
		__hx_this.__a = new T_c[0];
	}
	
	
	public static object __hx_cast<T_c_c>(global::Array me) {
		return ( (( me != null )) ? (me.Array_cast<T_c_c>()) : default(object) );
	}
	
	
	public static int __hx_toString_depth;
	
	public static int __hx_defaultCapacity;
	
	public static global::Array<X> ofNative<X>(X[] native) {
		return new global::Array<X>(((X[]) (native) ));
	}
	
	
	public static global::Array<Y> alloc<Y>(int size) {
		return new global::Array<Y>(((Y[]) (new Y[size]) ));
	}
	
	
	public object Array_cast<T_c>() {
		unchecked {
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				return this;
			}
			
			global::Array<T_c> new_me = new global::Array<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			global::Array<string> fields = global::Reflect.fields(this);
			int i = 0;
			while (( i < fields.length )) {
				string field = fields[i++];
				switch (field) {
					case "__a":
					{
						if (( this.__a != null )) {
							T_c[] __temp_new_arr1 = new T_c[this.__a.Length];
							int __temp_i2 = -1;
							while ((  ++ __temp_i2 < this.__a.Length )) {
								object __temp_obj3 = ((object) (this.__a[__temp_i2]) );
								if (( __temp_obj3 != null )) {
									__temp_new_arr1[__temp_i2] = global::haxe.lang.Runtime.genericCast<T_c>(__temp_obj3);
								}
								
							}
							
							new_me.__a = __temp_new_arr1;
						}
						else {
							new_me.__a = null;
						}
						
						break;
					}
					
					
					default:
					{
						global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
						break;
					}
					
				}
				
			}
			
			return new_me;
		}
	}
	
	
	public int length;
	
	public T[] __a;
	
	public global::Array<T> concat(global::Array<T> a) {
		int len = ( this.length + a.length );
		T[] retarr = new T[len];
		global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (0) ), ((global::System.Array) (retarr) ), ((int) (0) ), ((int) (this.length) ));
		global::System.Array.Copy(((global::System.Array) (a.__a) ), ((int) (0) ), ((global::System.Array) (retarr) ), ((int) (this.length) ), ((int) (a.length) ));
		return new global::Array<T>(((T[]) (retarr) ));
	}
	
	
	public void concatNative(T[] a) {
		T[] __a = this.__a;
		int len = ( this.length + ( a as global::System.Array ).Length );
		if (( ( __a as global::System.Array ).Length >= len )) {
			global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (this.length) ), ((int) (this.length) ));
		}
		else {
			T[] newarr = new T[len];
			global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (this.length) ));
			global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (this.length) ), ((int) (( a as global::System.Array ).Length) ));
			this.__a = newarr;
		}
		
		this.length = len;
	}
	
	
	public int indexOf(T x, global::haxe.lang.Null<int> fromIndex) {
		unchecked {
			int len = this.length;
			int i = ( ( ! (fromIndex.hasValue) ) ? (0) : ((fromIndex).@value) );
			if (( i < 0 )) {
				i += len;
				if (( i < 0 )) {
					i = 0;
				}
				
			}
			else if (( i >= len )) {
				return -1;
			}
			
			return global::System.Array.IndexOf<T>(((T[]) (this.__a) ), global::haxe.lang.Runtime.genericCast<T>(x), ((int) (i) ), ((int) (( len - i )) ));
		}
	}
	
	
	public int lastIndexOf(T x, global::haxe.lang.Null<int> fromIndex) {
		unchecked {
			int len = this.length;
			int i = ( ( ! (fromIndex.hasValue) ) ? (( len - 1 )) : ((fromIndex).@value) );
			if (( i >= len )) {
				i = ( len - 1 );
			}
			else if (( i < 0 )) {
				i += len;
				if (( i < 0 )) {
					return -1;
				}
				
			}
			
			return global::System.Array.LastIndexOf<T>(((T[]) (this.__a) ), global::haxe.lang.Runtime.genericCast<T>(x), ((int) (i) ), ((int) (( i + 1 )) ));
		}
	}
	
	
	public string @join(string sep) {
		unchecked {
			global::System.Text.StringBuilder buf_b = new global::System.Text.StringBuilder();
			int i = -1;
			bool first = true;
			int length = this.length;
			while ((  ++ i < length )) {
				if (first) {
					first = false;
				}
				else {
					buf_b.Append(((string) (global::Std.@string(sep)) ));
				}
				
				buf_b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.genericCast<T>(this.__a[i]))) ));
			}
			
			return buf_b.ToString();
		}
	}
	
	
	public global::haxe.lang.Null<T> pop() {
		T[] __a = this.__a;
		int length = this.length;
		if (( length > 0 )) {
			T val = global::haxe.lang.Runtime.genericCast<T>(__a[ -- length]);
			__a[length] = default(T);
			this.length = length;
			return new global::haxe.lang.Null<T>(val, true);
		}
		else {
			return default(global::haxe.lang.Null<T>);
		}
		
	}
	
	
	public int push(T x) {
		unchecked {
			if (( this.length >= ( this.__a as global::System.Array ).Length )) {
				int newLen = ( (( this.length == 0 )) ? (4) : (( this.length << 1 )) );
				T[] newarr = new T[newLen];
				( this.__a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
				this.__a = newarr;
			}
			
			this.__a[this.length] = x;
			return  ++ this.length;
		}
	}
	
	
	public void reverse() {
		unchecked {
			int i = 0;
			int l = this.length;
			T[] a = this.__a;
			int half = ( l >> 1 );
			 -- l;
			while (( i < half )) {
				T tmp = global::haxe.lang.Runtime.genericCast<T>(a[i]);
				a[i] = global::haxe.lang.Runtime.genericCast<T>(a[( l - i )]);
				a[( l - i )] = tmp;
				 ++ i;
			}
			
		}
	}
	
	
	public global::haxe.lang.Null<T> shift() {
		unchecked {
			int l = this.length;
			if (( l == 0 )) {
				return default(global::haxe.lang.Null<T>);
			}
			
			T[] a = this.__a;
			T x = global::haxe.lang.Runtime.genericCast<T>(a[0]);
			 -- l;
			global::System.Array.Copy(((global::System.Array) (a) ), ((int) (1) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (( this.length - 1 )) ));
			a[l] = default(T);
			this.length = l;
			return new global::haxe.lang.Null<T>(x, true);
		}
	}
	
	
	public global::Array<T> slice(int pos, global::haxe.lang.Null<int> end) {
		if (( pos < 0 )) {
			pos = ( this.length + pos );
			if (( pos < 0 )) {
				pos = 0;
			}
			
		}
		
		if ( ! (end.hasValue) ) {
			end = new global::haxe.lang.Null<int>(this.length, true);
		}
		else if (( (end).@value < 0 )) {
			end = new global::haxe.lang.Null<int>(( this.length + (end).@value ), true);
		}
		
		if (( (end).@value > this.length )) {
			end = new global::haxe.lang.Null<int>(this.length, true);
		}
		
		int len = ( (end).@value - pos );
		if (( len < 0 )) {
			return new global::Array<T>();
		}
		
		T[] newarr = new T[len];
		global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
		return new global::Array<T>(((T[]) (newarr) ));
	}
	
	
	public void sort(global::haxe.lang.Function f) {
		unchecked {
			if (( this.length == 0 )) {
				return;
			}
			
			this.quicksort(0, ( this.length - 1 ), f);
		}
	}
	
	
	public void quicksort(int lo, int hi, global::haxe.lang.Function f) {
		unchecked {
			T[] buf = this.__a;
			int i = lo;
			int j = hi;
			T p = global::haxe.lang.Runtime.genericCast<T>(buf[( ( i + j ) >> 1 )]);
			while (( i <= j )) {
				while (( ( i < hi ) && ( ((int) (f.__hx_invoke2_f(default(double), global::haxe.lang.Runtime.genericCast<T>(buf[i]), default(double), p)) ) < 0 ) )) {
					 ++ i;
				}
				
				while (( ( j > lo ) && ( ((int) (f.__hx_invoke2_f(default(double), global::haxe.lang.Runtime.genericCast<T>(buf[j]), default(double), p)) ) > 0 ) )) {
					 -- j;
				}
				
				if (( i <= j )) {
					T t = global::haxe.lang.Runtime.genericCast<T>(buf[i]);
					buf[i++] = global::haxe.lang.Runtime.genericCast<T>(buf[j]);
					buf[j--] = t;
				}
				
			}
			
			if (( lo < j )) {
				this.quicksort(lo, j, f);
			}
			
			if (( i < hi )) {
				this.quicksort(i, hi, f);
			}
			
		}
	}
	
	
	public global::Array<T> splice(int pos, int len) {
		if (( len < 0 )) {
			return new global::Array<T>();
		}
		
		if (( pos < 0 )) {
			pos = ( this.length + pos );
			if (( pos < 0 )) {
				pos = 0;
			}
			
		}
		
		if (( pos > this.length )) {
			pos = 0;
			len = 0;
		}
		else if (( ( pos + len ) > this.length )) {
			len = ( this.length - pos );
			if (( len < 0 )) {
				len = 0;
			}
			
		}
		
		T[] a = this.__a;
		T[] ret = new T[len];
		global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (ret) ), ((int) (0) ), ((int) (len) ));
		global::Array<T> ret1 = new global::Array<T>(((T[]) (ret) ));
		int end = ( pos + len );
		global::System.Array.Copy(((global::System.Array) (a) ), ((int) (end) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( this.length - end )) ));
		this.length -= len;
		while ((  -- len >= 0 )) {
			a[( this.length + len )] = default(T);
		}
		
		return ret1;
	}
	
	
	public void spliceVoid(int pos, int len) {
		if (( len < 0 )) {
			return;
		}
		
		if (( pos < 0 )) {
			pos = ( this.length + pos );
			if (( pos < 0 )) {
				pos = 0;
			}
			
		}
		
		if (( pos > this.length )) {
			pos = 0;
			len = 0;
		}
		else if (( ( pos + len ) > this.length )) {
			len = ( this.length - pos );
			if (( len < 0 )) {
				len = 0;
			}
			
		}
		
		T[] a = this.__a;
		int end = ( pos + len );
		global::System.Array.Copy(((global::System.Array) (a) ), ((int) (end) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( this.length - end )) ));
		this.length -= len;
		while ((  -- len >= 0 )) {
			a[( this.length + len )] = default(T);
		}
		
	}
	
	
	public string toString() {
		unchecked {
			if (( global::Array<object>.__hx_toString_depth >= 5 )) {
				return "...";
			}
			
			 ++ global::Array<object>.__hx_toString_depth;
			try {
				string s = this.__hx_toString();
				 -- global::Array<object>.__hx_toString_depth;
				return s;
			}
			catch (global::System.Exception _g){
				object e = ((object) (global::haxe.Exception.caught(_g).unwrap()) );
				 -- global::Array<object>.__hx_toString_depth;
				throw ((global::System.Exception) (global::haxe.Exception.thrown(e)) );
			}
			
			
		}
	}
	
	
	public string __hx_toString() {
		global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
		T[] a = this.__a;
		ret_b.Append(((string) ("[") ));
		bool first = true;
		{
			int _g = 0;
			int _g1 = this.length;
			while (( _g < _g1 )) {
				int i = _g++;
				if (first) {
					first = false;
				}
				else {
					ret_b.Append(((string) (",") ));
				}
				
				ret_b.Append(((string) (global::Std.@string(global::haxe.lang.Runtime.genericCast<T>(a[i]))) ));
			}
			
		}
		
		ret_b.Append(((string) ("]") ));
		return ret_b.ToString();
	}
	
	
	public void unshift(T x) {
		unchecked {
			T[] __a = this.__a;
			int length = this.length;
			if (( length >= ( __a as global::System.Array ).Length )) {
				int newLen = ( (( length << 1 )) + 1 );
				T[] newarr = new T[newLen];
				global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (1) ), ((int) (length) ));
				this.__a = newarr;
			}
			else {
				global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (1) ), ((int) (length) ));
			}
			
			this.__a[0] = x;
			 ++ this.length;
		}
	}
	
	
	public void insert(int pos, T x) {
		unchecked {
			int l = this.length;
			if (( pos < 0 )) {
				pos = ( l + pos );
				if (( pos < 0 )) {
					pos = 0;
				}
				
			}
			
			if (( pos >= l )) {
				this.push(x);
				return;
			}
			else if (( pos == 0 )) {
				this.unshift(x);
				return;
			}
			
			if (( l >= ( this.__a as global::System.Array ).Length )) {
				int newLen = ( (( this.length << 1 )) + 1 );
				T[] newarr = new T[newLen];
				global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (pos) ));
				newarr[pos] = x;
				global::System.Array.Copy(((global::System.Array) (this.__a) ), ((int) (pos) ), ((global::System.Array) (newarr) ), ((int) (( pos + 1 )) ), ((int) (( l - pos )) ));
				this.__a = newarr;
				 ++ this.length;
			}
			else {
				T[] __a = this.__a;
				global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (pos) ), ((global::System.Array) (__a) ), ((int) (( pos + 1 )) ), ((int) (( l - pos )) ));
				global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (__a) ), ((int) (0) ), ((int) (pos) ));
				__a[pos] = x;
				 ++ this.length;
			}
			
		}
	}
	
	
	public bool @remove(T x) {
		unchecked {
			T[] __a = this.__a;
			int i = -1;
			int length = this.length;
			while ((  ++ i < length )) {
				if (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.genericCast<T>(__a[i]), x)) {
					global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (( i + 1 )) ), ((global::System.Array) (__a) ), ((int) (i) ), ((int) (( ( length - i ) - 1 )) ));
					__a[ -- this.length] = default(T);
					return true;
				}
				
			}
			
			return false;
		}
	}
	
	
	public global::Array<S> map<S>(global::haxe.lang.Function f) {
		global::Array<S> ret = new global::Array<S>(((S[]) (new S[this.length]) ));
		{
			int _g = 0;
			int _g1 = this.length;
			while (( _g < _g1 )) {
				int i = _g++;
				{
					S val = global::haxe.lang.Runtime.genericCast<S>(f.__hx_invoke1_o(default(double), global::haxe.lang.Runtime.genericCast<T>(this.__a[i])));
					ret.__a[i] = val;
				}
				
			}
			
		}
		
		return ret;
	}
	
	
	public bool contains(T x) {
		unchecked {
			T[] __a = this.__a;
			int i = -1;
			int length = this.length;
			while ((  ++ i < length )) {
				if (global::haxe.lang.Runtime.eq(global::haxe.lang.Runtime.genericCast<T>(__a[i]), x)) {
					return true;
				}
				
			}
			
			return false;
		}
	}
	
	
	public global::Array<T> filter(global::haxe.lang.Function f) {
		global::Array<T> ret = new global::Array<T>(new T[]{});
		{
			int _g = 0;
			int _g1 = this.length;
			while (( _g < _g1 )) {
				int i = _g++;
				T elt = global::haxe.lang.Runtime.genericCast<T>(this.__a[i]);
				if (global::haxe.lang.Runtime.toBool(f.__hx_invoke1_o(default(double), elt))) {
					ret.push(elt);
				}
				
			}
			
		}
		
		return ret;
	}
	
	
	public global::Array<T> copy() {
		int len = this.length;
		T[] __a = this.__a;
		T[] newarr = new T[len];
		global::System.Array.Copy(((global::System.Array) (__a) ), ((int) (0) ), ((global::System.Array) (newarr) ), ((int) (0) ), ((int) (len) ));
		return new global::Array<T>(((T[]) (newarr) ));
	}
	
	
	public global::haxe.iterators.ArrayIterator<T> iterator() {
		return new global::haxe.iterators.ArrayIterator<T>(((global::Array<T>) (this) ));
	}
	
	
	public global::haxe.iterators.ArrayKeyValueIterator<T> keyValueIterator() {
		return new global::haxe.iterators.ArrayKeyValueIterator<T>(((global::Array<T>) (this) ));
	}
	
	
	public void resize(int len) {
		if (( this.length < len )) {
			if (( ( this.__a as global::System.Array ).Length < len )) {
				global::System.Array.Resize<T>(ref this.__a, ((int) (len) ));
			}
			
			this.length = len;
		}
		else if (( this.length > len )) {
			this.spliceVoid(len, ( this.length - len ));
		}
		
	}
	
	
	public T __get(int idx) {
		if (( ((uint) (idx) ) >= this.length )) {
			return default(T);
		}
		else {
			return global::haxe.lang.Runtime.genericCast<T>(this.__a[idx]);
		}
		
	}
	
	
	public T __set(int idx, T v) {
		unchecked {
			uint idx1 = ((uint) (idx) );
			T[] __a = this.__a;
			if (( idx1 >= ( __a as global::System.Array ).Length )) {
				uint len = ((uint) (( idx1 + 1 )) );
				if (( idx1 == ( __a as global::System.Array ).Length )) {
					len = ((uint) (( (( idx1 << 1 )) + 1 )) );
				}
				
				T[] newArr = new T[((int) (len) )];
				( __a as global::System.Array ).CopyTo(((global::System.Array) (newArr) ), ((int) (0) ));
				__a = newArr;
				this.__a = __a;
			}
			
			if (( idx1 >= this.length )) {
				this.length = ((int) (((uint) (( idx1 + 1 )) )) );
			}
			
			return __a[((int) (idx1) )] = v;
		}
	}
	
	
	public T __unsafe_get(int idx) {
		return global::haxe.lang.Runtime.genericCast<T>(this.__a[idx]);
	}
	
	
	public T __unsafe_set(int idx, T val) {
		return this.__a[idx] = val;
	}
	
	
	public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 520590566:
				{
					this.length = ((int) (@value) );
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
				case 4745537:
				{
					this.__a = ((T[]) (@value) );
					return @value;
				}
				
				
				case 520590566:
				{
					this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
				case 1621420777:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__unsafe_set", 1621420777)) );
				}
				
				
				case 1620824029:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__unsafe_get", 1620824029)) );
				}
				
				
				case 1916009602:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__set", 1916009602)) );
				}
				
				
				case 1915412854:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "__get", 1915412854)) );
				}
				
				
				case 142301684:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "resize", 142301684)) );
				}
				
				
				case 1257164128:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "keyValueIterator", 1257164128)) );
				}
				
				
				case 328878574:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "iterator", 328878574)) );
				}
				
				
				case 1103412149:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "copy", 1103412149)) );
				}
				
				
				case 87367608:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "filter", 87367608)) );
				}
				
				
				case 746281503:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "contains", 746281503)) );
				}
				
				
				case 5442204:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "map", 5442204)) );
				}
				
				
				case 76061764:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "remove", 76061764)) );
				}
				
				
				case 501039929:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "insert", 501039929)) );
				}
				
				
				case 2025055113:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "unshift", 2025055113)) );
				}
				
				
				case 946786476:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "toString", 946786476)) );
				}
				
				
				case 1352786672:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "spliceVoid", 1352786672)) );
				}
				
				
				case 1067353468:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "splice", 1067353468)) );
				}
				
				
				case 1282943179:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "quicksort", 1282943179)) );
				}
				
				
				case 1280845662:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "sort", 1280845662)) );
				}
				
				
				case 2127021138:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "slice", 2127021138)) );
				}
				
				
				case 2082663554:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "shift", 2082663554)) );
				}
				
				
				case 452737314:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "reverse", 452737314)) );
				}
				
				
				case 1247875546:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "push", 1247875546)) );
				}
				
				
				case 5594513:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "pop", 5594513)) );
				}
				
				
				case 1181037546:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "join", 1181037546)) );
				}
				
				
				case 359333139:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "lastIndexOf", 359333139)) );
				}
				
				
				case 1623148745:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "indexOf", 1623148745)) );
				}
				
				
				case 1532710347:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "concatNative", 1532710347)) );
				}
				
				
				case 1204816148:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "concat", 1204816148)) );
				}
				
				
				case 4745537:
				{
					return this.__a;
				}
				
				
				case 520590566:
				{
					return this.length;
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
				case 520590566:
				{
					return ((double) (this.length) );
				}
				
				
				default:
				{
					return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
				}
				
			}
			
		}
	}
	
	
	public override object __hx_invokeField(string field, int hash, object[] dynargs) {
		unchecked {
			switch (hash) {
				case 1621420777:
				{
					return this.__unsafe_set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
				}
				
				
				case 1620824029:
				{
					return this.__unsafe_get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 1916009602:
				{
					return this.__set(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
				}
				
				
				case 1915412854:
				{
					return this.__get(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
				}
				
				
				case 142301684:
				{
					this.resize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
					break;
				}
				
				
				case 1257164128:
				{
					return this.keyValueIterator();
				}
				
				
				case 328878574:
				{
					return this.iterator();
				}
				
				
				case 1103412149:
				{
					return this.copy();
				}
				
				
				case 87367608:
				{
					return this.filter(((global::haxe.lang.Function) (dynargs[0]) ));
				}
				
				
				case 746281503:
				{
					return this.contains(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
				}
				
				
				case 5442204:
				{
					return this.map<object>(((global::haxe.lang.Function) (dynargs[0]) ));
				}
				
				
				case 76061764:
				{
					return this.@remove(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
				}
				
				
				case 501039929:
				{
					this.insert(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Runtime.genericCast<T>(dynargs[1]));
					break;
				}
				
				
				case 2025055113:
				{
					this.unshift(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
					break;
				}
				
				
				case 946786476:
				{
					return this.toString();
				}
				
				
				case 1352786672:
				{
					this.spliceVoid(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
					break;
				}
				
				
				case 1067353468:
				{
					return this.splice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ));
				}
				
				
				case 1282943179:
				{
					this.quicksort(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((int) (global::haxe.lang.Runtime.toInt(dynargs[1])) ), ((global::haxe.lang.Function) (dynargs[2]) ));
					break;
				}
				
				
				case 1280845662:
				{
					this.sort(((global::haxe.lang.Function) (dynargs[0]) ));
					break;
				}
				
				
				case 2127021138:
				{
					return this.slice(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 1 )) ? (dynargs[1]) : (null) )));
				}
				
				
				case 2082663554:
				{
					return (this.shift()).toDynamic();
				}
				
				
				case 452737314:
				{
					this.reverse();
					break;
				}
				
				
				case 1247875546:
				{
					return this.push(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
				}
				
				
				case 5594513:
				{
					return (this.pop()).toDynamic();
				}
				
				
				case 1181037546:
				{
					return this.@join(global::haxe.lang.Runtime.toString(dynargs[0]));
				}
				
				
				case 359333139:
				{
					return this.lastIndexOf(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 1 )) ? (dynargs[1]) : (null) )));
				}
				
				
				case 1623148745:
				{
					return this.indexOf(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]), global::haxe.lang.Null<object>.ofDynamic<int>(( (( dynargs.Length > 1 )) ? (dynargs[1]) : (null) )));
				}
				
				
				case 1532710347:
				{
					this.concatNative(((T[]) (dynargs[0]) ));
					break;
				}
				
				
				case 1204816148:
				{
					return this.concat(((global::Array<T>) (global::Array<object>.__hx_cast<T>(((global::Array) (dynargs[0]) ))) ));
				}
				
				
				default:
				{
					return base.__hx_invokeField(field, hash, dynargs);
				}
				
			}
			
			return null;
		}
	}
	
	
	public override void __hx_getFields(global::Array<string> baseArr) {
		baseArr.push("__a");
		baseArr.push("length");
		base.__hx_getFields(baseArr);
	}
	
	
	public T this[int index]{
		get{
			return this.__get(index);
		}
		set{
			this.__set(index,value);
		}
	}
	object global::Array.this[int key]{
		get{
			return ((object) this.__get(key));
		}
		set{
			this.__set(key, (T) value);
		}
	}
	
	
	public override string ToString(){
		return this.toString();
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
[global::haxe.lang.GenericInterface(typeof(global::Array<object>))]
public interface Array : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
	
	object Array_cast<T_c>();
	
	string @join(string sep);
	
	void reverse();
	
	void spliceVoid(int pos, int len);
	
	string toString();
	
	string __hx_toString();
	
	void resize(int len);
	
	object this[int key]{
		get;
		set;
	}
	
	
}


