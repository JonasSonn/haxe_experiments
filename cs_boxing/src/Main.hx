package;

class Main {
    static function main() {
        var s : ClassicSomeType = { a: 0, b: 1.0};
        doSomething(s);
        var s2 : ClassicSomeType2<Float> = { a: 0, b: 1.0};
        doSomething2(s2);
        var g1  = new GenericType<Float, Null<Float>>(0.0, 1.0);
        doSomething3(g1);

    }

    @:keep
    static function doSomething(s : ClassicSomeType) : Bool {
        var t = s.a + 0.5;
        var t_b = s.b + 0.5;
        return false;
    }
    @:keep
    static function doSomething2(s : ClassicSomeType2<Float>) : Bool {
        var t = s.a + 0.5;
        var t_b = s.b + 0.5;
        return false;
    }
    @:keep
    static function doSomething3(s : GenericType<Float, Null<Float>>) : Bool {
        var t = s.a + 0.5;
        var t_b = s.b + 0.5;
        return false;
    }


    
}

typedef ClassicSomeType = {
    a : Float,
    b : Null<Float>
}

typedef ClassicSomeType2<T> = {
    a : T,
    b : Null<T>
}
@:structInit
@:generic
class GenericType<T, B> {
    public var a: T;
    public var b: B;
    public function new(a : T, b : B) {
        this.a = a;
        this.b = b;        
    }
}