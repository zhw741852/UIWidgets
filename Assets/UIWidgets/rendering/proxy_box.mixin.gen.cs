﻿using UIWidgets.ui;
using UnityEngine;

namespace UIWidgets.rendering {



    public abstract class RenderProxyBoxMixinRenderObjectWithChildMixinRenderBox<T> : RenderObjectWithChildMixinRenderBox<T> where T : RenderBox {
        public override void setupParentData(RenderObject child) {
            if (!(child.parentData is ParentData)) {
                child.parentData = new ParentData();
            }
        }

        public override double computeMinIntrinsicWidth(double height) {
            if (this.child != null) {
                return this.child.getMinIntrinsicWidth(height);
            }

            return 0.0;
        }

        public override double computeMaxIntrinsicWidth(double height) {
            if (this.child != null) {
                return this.child.getMaxIntrinsicWidth(height);
            }

            return 0.0;
        }

        public override double computeMinIntrinsicHeight(double width) {
            if (this.child != null) {
                return this.child.getMinIntrinsicHeight(width);
            }

            return 0.0;
        }

        public override double computeMaxIntrinsicHeight(double width) {
            if (this.child != null) {
                return this.child.getMaxIntrinsicHeight(width);
            }

            return 0.0;
        }

        public override double? computeDistanceToActualBaseline(TextBaseline baseline) {
            if (this.child != null) {
                return this.child.getDistanceToActualBaseline(baseline);
            }

            return base.computeDistanceToActualBaseline(baseline);
        }

        public override void performLayout() {
            if (this.child != null) {
                this.child.layout(this.constraints, parentUsesSize: true);
                this.size = this.child.size;
            } else {
                this.performResize();
            }
        }

        public override void applyPaintTransform(RenderObject child, ref Matrix4x4 transform) {
        }

        public override void paint(PaintingContext context, Offset offset) {
            if (this.child != null) {
                context.paintChild(this.child, offset);
            }
        }
    }


}