
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class ValueException : global::haxe.Exception {
		
		public ValueException(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public ValueException(object @value, global::haxe.Exception previous, object native) : base(((string) (global::Std.@string(((object) (@value) ))) ), ((global::haxe.Exception) (( (( previous == null )) ? (null) : (previous) )) ), ((object) (( (( native == null )) ? (null) : (native) )) )) {
			this.@value = @value;
		}
		
		
		public object @value;
		
		public override object unwrap() {
			return this.@value;
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 834174833:
					{
						this.@value = ((object) (@value) );
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
					case 834174833:
					{
						this.@value = ((object) (@value) );
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
					case 1825849507:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "unwrap", 1825849507)) );
					}
					
					
					case 834174833:
					{
						return this.@value;
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
					case 834174833:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(this.@value)) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			baseArr.push("value");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


