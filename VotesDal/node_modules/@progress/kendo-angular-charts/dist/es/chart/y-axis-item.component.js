/**-----------------------------------------------------------------------------------------
* Copyright © 2021 Progress Software Corporation. All rights reserved.
* Licensed under commercial license. See LICENSE.md in the project root for more information
*-------------------------------------------------------------------------------------------*/
import * as tslib_1 from "tslib";
import { Component, ChangeDetectionStrategy, Input } from '@angular/core';
import { CollectionService } from '../common/collection.service';
import { ConfigurationService } from '../common/configuration.service';
import { YAxisItemComponentGenerated } from './y-axis-item.component.generated';
/**
 * The configuration component for the Y axis
 * ([see example]({% slug api_charts_yaxiscomponent %})).
 */
var YAxisItemComponent = /** @class */ (function (_super) {
    tslib_1.__extends(YAxisItemComponent, _super);
    function YAxisItemComponent(configurationService, collectionService) {
        var _this = _super.call(this, configurationService, collectionService) || this;
        _this.configurationService = configurationService;
        _this.collectionService = collectionService;
        return _this;
    }
    tslib_1.__decorate([
        Input(),
        tslib_1.__metadata("design:type", Array)
    ], YAxisItemComponent.prototype, "categories", void 0);
    YAxisItemComponent = tslib_1.__decorate([
        Component({
            changeDetection: ChangeDetectionStrategy.OnPush,
            providers: [ConfigurationService],
            selector: 'kendo-chart-y-axis-item',
            template: ''
        }),
        tslib_1.__metadata("design:paramtypes", [ConfigurationService,
            CollectionService])
    ], YAxisItemComponent);
    return YAxisItemComponent;
}(YAxisItemComponentGenerated));
export { YAxisItemComponent };
