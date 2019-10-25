# ComponentAutoBindTool
9102年了作为底层拼图仔的你还在Unity里手写组件绑定代码？快来试试这款船新的组件自动绑定工具吧，只需三分钟，你就会爱上它。

实现了editor时期使用字符串，runtime时期使用索引获取组件，以消除不必要的内存分配。

支持自定义自动绑定规则，提供了默认的自动绑定规则，根据物体命名前缀进行组件识别，支持单个物体的多组件识别绑定。

基本用法：为要进行自动绑定物体挂载ComponentAutoBindTool脚本，点击自动绑定组件，然后设置自动生成的绑定代码的命名空间，类名与保存路径，最后点击生成绑定代码即可。

本项目基于 https://github.com/egametang/ET 中的 ReferenceCollector 开发。
