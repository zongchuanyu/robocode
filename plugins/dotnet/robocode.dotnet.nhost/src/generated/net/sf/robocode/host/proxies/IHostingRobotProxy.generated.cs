//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.host.proxies {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IHostingRobotProxy {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void cleanup();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/peer/ExecCommands;Lrobocode/RobotStatus;)V")]
        void startRound(global::java.lang.Object par0, global::java.lang.Object par1);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void forceStopThread();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void waitForStopThread();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IHostingRobotProxy_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.host.proxies.@__IHostingRobotProxy.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.robocode.host.proxies.IHostingRobotProxy), typeof(global::net.sf.robocode.host.proxies.IHostingRobotProxy_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.robocode.host.proxies.IHostingRobotProxy), typeof(global::net.sf.robocode.host.proxies.IHostingRobotProxy_))]
    internal sealed partial class @__IHostingRobotProxy : global::java.lang.Object, global::net.sf.robocode.host.proxies.IHostingRobotProxy {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _cleanup0;
        
        internal static global::net.sf.jni4net.jni.MethodId _startRound1;
        
        internal static global::net.sf.jni4net.jni.MethodId _forceStopThread2;
        
        internal static global::net.sf.jni4net.jni.MethodId _waitForStopThread3;
        
        private @__IHostingRobotProxy(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.host.proxies.@__IHostingRobotProxy.staticClass = @__class;
            global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._cleanup0 = @__env.GetMethodID(global::net.sf.robocode.host.proxies.@__IHostingRobotProxy.staticClass, "cleanup", "()V");
            global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._startRound1 = @__env.GetMethodID(global::net.sf.robocode.host.proxies.@__IHostingRobotProxy.staticClass, "startRound", "(Lnet/sf/robocode/peer/ExecCommands;Lrobocode/RobotStatus;)V");
            global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._forceStopThread2 = @__env.GetMethodID(global::net.sf.robocode.host.proxies.@__IHostingRobotProxy.staticClass, "forceStopThread", "()V");
            global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._waitForStopThread3 = @__env.GetMethodID(global::net.sf.robocode.host.proxies.@__IHostingRobotProxy.staticClass, "waitForStopThread", "()V");
        }
        
        public void cleanup() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._cleanup0);
            }
        }
        
        public void startRound(global::java.lang.Object par0, global::java.lang.Object par1) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 14)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._startRound1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par1));
            }
        }
        
        public void forceStopThread() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._forceStopThread2);
            }
        }
        
        public void waitForStopThread() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            using(new global::net.sf.jni4net.jni.LocalFrame(@__env, 10)){
            @__env.CallVoidMethod(this, global::net.sf.robocode.host.proxies.@__IHostingRobotProxy._waitForStopThread3);
            }
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IHostingRobotProxy);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "cleanup", "cleanup0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "startRound", "startRound1", "(Lnet/sf/robocode/peer/ExecCommands;Lrobocode/RobotStatus;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "forceStopThread", "forceStopThread2", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "waitForStopThread", "waitForStopThread3", "()V"));
            return methods;
        }
        
        private static void cleanup0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.proxies.IHostingRobotProxy @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.proxies.IHostingRobotProxy>(@__env, @__obj);
            @__real.cleanup();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void startRound1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0, global::net.sf.jni4net.utils.JniLocalHandle par1) {
            // (Lnet/sf/robocode/peer/ExecCommands;Lrobocode/RobotStatus;)V
            // (Ljava/lang/Object;Ljava/lang/Object;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.proxies.IHostingRobotProxy @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.proxies.IHostingRobotProxy>(@__env, @__obj);
            @__real.startRound(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0), global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par1));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void forceStopThread2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.proxies.IHostingRobotProxy @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.proxies.IHostingRobotProxy>(@__env, @__obj);
            @__real.forceStopThread();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void waitForStopThread3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.host.proxies.IHostingRobotProxy @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.host.proxies.IHostingRobotProxy>(@__env, @__obj);
            @__real.waitForStopThread();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.host.proxies.@__IHostingRobotProxy(@__env);
            }
        }
    }
    #endregion
}